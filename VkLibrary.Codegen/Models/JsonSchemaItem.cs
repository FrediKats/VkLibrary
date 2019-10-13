using System;
using Newtonsoft.Json.Linq;
using VkLibrary.Codegen.Types;

namespace VkLibrary.Codegen.Models
{
    public class JsonSchemaItem
    {
        public string Title { get; set; }
        public JsonSchemaItemType ObjectType { get; set; }
        public JObject Body { get; set; }
        public string Description { get; set; }

        public static JsonSchemaItem Create(string key, JObject schemeObject)
        {
            if (!schemeObject.ContainsKey("type"))
                throw new ArgumentException($"Object don't contains type: {schemeObject}");

            var type = schemeObject["type"].Value<string>();
            JsonSchemaItemType itemType = type switch
            {
                "object" when schemeObject.ContainsKey(ClassDescriptor.ClassPropertiesField) => JsonSchemaItemType.Class,
                "object" when schemeObject.ContainsKey(ClassDescriptor.AllOfGroupField) => JsonSchemaItemType.Class,
                "object" when schemeObject.ContainsKey(ClassDescriptor.OneOfGroupField) => JsonSchemaItemType.Class,
                "string" => JsonSchemaItemType.Enum,
                "integer" => JsonSchemaItemType.Enum,
                _ => throw new ArgumentException($"Invalid type: {type}")
            };

            return new JsonSchemaItem
            {
                Body = schemeObject,
                Title = key,
                ObjectType = itemType,
                Description = schemeObject.Value<string>("description")
            };
        }

        public override string ToString()
        {
            return $"[type: {ObjectType}; title: {Title}]";
        }
    }
}