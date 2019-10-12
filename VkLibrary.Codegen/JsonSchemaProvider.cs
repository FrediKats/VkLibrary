using System.Collections.Generic;
using System.IO;
using System.Linq;
using Newtonsoft.Json;
using VkLibrary.Codegen.Models;
using VkLibrary.Codegen.Types;

namespace VkLibrary.Codegen
{
    public static class JsonSchemaProvider
    {
        public static List<ClassDescriptor> GetClassDescriptor()
        {
            var schema = JsonConvert.DeserializeObject<JsonSchemaModel>(File.ReadAllText("Schemes/objects.json"));

            return schema.Definitions
                .Select(pair => JsonSchemaItem.Create(pair.Key, pair.Value))
                .Where(i => i.ObjectType == JsonSchemaItemType.Class)
                .Select(c => new ClassDescriptor(c))
                .ToList();
        }

        public static List<EnumDescriptor> GetEnumDescriptor()
        {
            var schema = JsonConvert.DeserializeObject<JsonSchemaModel>(File.ReadAllText("Schemes/objects.json"));

            return schema.Definitions
                .Select(pair => JsonSchemaItem.Create(pair.Key, pair.Value))
                .Where(i => i.ObjectType == JsonSchemaItemType.Enum)
                .Select(c => new EnumDescriptor(c))
                .ToList();
        }
    }
}