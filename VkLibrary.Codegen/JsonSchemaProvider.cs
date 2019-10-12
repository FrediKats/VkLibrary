using System;
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
        public static List<JsonSchemaItem> GetSchemeForResponses()
        {
            var schema = JsonConvert.DeserializeObject<JsonSchemaModel>(File.ReadAllText("Schemes/objects.json"));

            List<JsonSchemaItem> items = schema.Definitions
                .Select(pair => JsonSchemaItem.Create(pair.Key, pair.Value))
                .ToList();

            List<ClassDescriptor> classes = items
                .Where(i => i.ObjectType == JsonSchemaItemType.Class)
                .Select(c => new ClassDescriptor(c))
                .ToList();

            classes.ForEach(Console.WriteLine);

            return items;
        }
    }
}