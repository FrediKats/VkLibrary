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
        public static readonly JsonSchemaModel ObjectSchemaModel;

        static JsonSchemaProvider()
        {
            ObjectSchemaModel = JsonConvert.DeserializeObject<JsonSchemaModel>(File.ReadAllText("Schemes/objects.json"));
        }

        public List<ClassDescriptor> GetClassDescriptor()
        {
            return ObjectSchemaModel.Definitions
                .Select(pair => JsonSchemaItem.Create(pair.Key, pair.Value))
                .Where(i => i.ObjectType == JsonSchemaItemType.Class)
                .Select(c => new ClassDescriptor(c))
                .ToList();
        }

        public List<EnumDescriptor> GetEnumDescriptor()
        {
            return ObjectSchemaModel.Definitions
                .Select(pair => JsonSchemaItem.Create(pair.Key, pair.Value))
                .Where(i => i.ObjectType == JsonSchemaItemType.Enum)
                .Select(c => new EnumDescriptor(c))
                .ToList();
        }

        public List<JsonSchemaItem> GetUndefined()
        {
            return ObjectSchemaModel.Definitions
                .Select(pair => JsonSchemaItem.Create(pair.Key, pair.Value))
                .Where(i => i.ObjectType == JsonSchemaItemType.Undefined)
                .ToList();
        }
    }
}