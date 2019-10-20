using System.Collections.Generic;
using System.IO;
using System.Linq;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using VkLibrary.Codegen.JsonModel;
using VkLibrary.Codegen.Models;
using VkLibrary.Codegen.Tools;
using VkLibrary.Codegen.Types;
using VkLibrary.Codegen.Types.TitleCase;

namespace VkLibrary.Codegen
{
    public class JsonSchemaProvider
    {
        private readonly List<MethodDescriptor> _methodsSchemaModel;
        private readonly List<JsonSchemaItem> _objectSchemaModel;
        private readonly List<JsonSchemaItem> _responseSchemaModel;

        public JsonSchemaProvider()
        {
            _objectSchemaModel = JsonConvert
                .DeserializeObject<JsonSchemaModel>(File.ReadAllText("Schemes/objects.json"))
                .Definitions
                .Select(pair => JsonSchemaItem.Create(pair.Key, pair.Value))
                .ToList();

            Dictionary<string, JObject> responseDefinition = JsonConvert
                .DeserializeObject<JsonSchemaModel>(File.ReadAllText("Schemes/responses.json"))
                .Definitions;

            // known problem: bug with parsing
            Log.Instance.Message("Skip type parse for: messages_delete_response");
            Log.Instance.Message("Skip type parse for: newsfeed_getSuggestedSources_response");
            Log.Instance.Message("Skip type parse for: account_getAppPermissions_response is equals to int");
            responseDefinition.Remove("messages_delete_response");
            responseDefinition.Remove("newsfeed_getSuggestedSources_response");
            responseDefinition.Remove("account_getAppPermissions_response");

            _responseSchemaModel = responseDefinition
                .Select(pair => JsonSchemaItem.Create(pair.Key, pair.Value))
                .ToList();

            _responseSchemaModel
                .ForEach(r => { r.Body = r.Body["properties"]["response"]; });

            _methodsSchemaModel = JsonConvert
                .DeserializeObject<MethodJsonModel>(File.ReadAllText("Schemes/methods.json"))
                .Methods
                .Where(m => m.Description != null)
                .Where(FilterUnsupportedMethods)
                .Select(m => new MethodDescriptor(m))
                .ToList();
        }

        public List<ClassDescriptor> GetObjectClassDescriptor()
        {
            return _objectSchemaModel
                .Where(i => i.ObjectType == JsonSchemaItemType.Class)
                .Select(c => new ClassDescriptor(c))
                .ToList();
        }

        public List<EnumDescriptor> GetObjectEnumDescriptor()
        {
            return _objectSchemaModel
                .Where(i => i.ObjectType == JsonSchemaItemType.Enum)
                .Select(c => new EnumDescriptor(c))
                .ToList();
        }

        public List<ClassDescriptor> GetResponseClassDescriptors()
        {
            return _responseSchemaModel
                .Where(FilterResponses)
                .Select(r => new ClassDescriptor(r))
                .ToList();
        }

        public List<MethodDescriptor> GetMethodDescriptors()
        {
            return _methodsSchemaModel;
        }

        public bool FilterResponses(JsonSchemaItem item)
        {
            string originalTypeName = CamelCaseTitle.Of(item.Title).ToSharpString();
            string typeToReplace = null;

            JToken refBlock = item.Body["$ref"];
            if (refBlock != null)
                typeToReplace = TypeParser.GetTypeFromRef(item.Body);

            var jsonType = item.Body.Value<string>("type");
            if (jsonType != null && jsonType != "object")
                typeToReplace = jsonType;

            if (typeToReplace != null)
            {
                typeToReplace = TypeParser
                    .MatchDefaultType(typeToReplace)
                    .ToSharpString();
                TypeProvider.Instance.Register(originalTypeName, typeToReplace);
                return false;
            }

            return true;
        }

        public List<JsonSchemaItem> GetUndefined()
        {
            return _objectSchemaModel
                .Concat(_responseSchemaModel)
                .Where(i => i.ObjectType == JsonSchemaItemType.Undefined)
                .ToList();
        }

        private bool FilterUnsupportedMethods(MethodData methodData)
        {
            bool result = methodData.Name switch
            {
                // known problem: bug with parsing
                "storage.get" => false,
                "messages.delete" => false,
                "newsfeed.getSuggestedSources" => false,
                _ => true
            };

            if (!result)
                Log.Instance.Message($"Skip type parse for: {methodData.Name}");

            return result;
        }
    }
}