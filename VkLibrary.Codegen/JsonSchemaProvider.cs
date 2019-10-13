using System.Collections.Generic;
using System.IO;
using System.Linq;
using Newtonsoft.Json;
using VkLibrary.Codegen.Models;
using VkLibrary.Codegen.Types;

namespace VkLibrary.Codegen
{
    public class JsonSchemaProvider
    {
        private readonly JsonSchemaModel _objectSchemaModel;

        public JsonSchemaProvider(string filePath)
        {
            _objectSchemaModel = JsonConvert.DeserializeObject<JsonSchemaModel>(File.ReadAllText(filePath));
        }

        public List<ClassDescriptor> GetClassDescriptor()
        {
            return _objectSchemaModel.Definitions
                .Select(pair => JsonSchemaItem.Create(pair.Key, pair.Value))
                .Where(i => i.ObjectType == JsonSchemaItemType.Class)
                .Select(c => new ClassDescriptor(c))
                .ToList();
        }
        public List<ClassDescriptor> GetResponseClassDescriptors()
        {
            // known problem: bug with parsing
            _objectSchemaModel.Definitions.Remove("messages_delete_response");
            _objectSchemaModel.Definitions.Remove("newsfeed_getSuggestedSources_response");
            _objectSchemaModel.Definitions.Remove("notifications_get_response");

            return _objectSchemaModel.Definitions
                .Select(pair => JsonSchemaItem.Create(pair.Key, pair.Value))
                .Where(i => i.ObjectType == JsonSchemaItemType.Class)
                .Select(ConvertIfNested)
                .ToList();
        }

        public ClassDescriptor ConvertIfNested(JsonSchemaItem jsonSchemaItem)
        {
            if (jsonSchemaItem.Body["properties"]["response"].Value<string>("type") == "object")
            {
                jsonSchemaItem.Body = jsonSchemaItem.Body["properties"]["response"];
            }
            return new ClassDescriptor(jsonSchemaItem);
        }

        public List<EnumDescriptor> GetEnumDescriptor()
        {
            return _objectSchemaModel.Definitions
                .Select(pair => JsonSchemaItem.Create(pair.Key, pair.Value))
                .Where(i => i.ObjectType == JsonSchemaItemType.Enum)
                .Select(c => new EnumDescriptor(c))
                .ToList();
        }

        public List<JsonSchemaItem> GetUndefined()
        {
            return _objectSchemaModel.Definitions
                .Select(pair => JsonSchemaItem.Create(pair.Key, pair.Value))
                .Where(i => i.ObjectType == JsonSchemaItemType.Undefined)
                .ToList();
        }
    }
}