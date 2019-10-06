using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using VkLibrary.Codegen.EntitiesGenerator;
using VkLibrary.Codegen.Models;
using VkLibrary.Codegen.Tools;

namespace VkLibrary.Codegen
{
    public static class JsonSchemaProvider
    {
        public static List<string> GetSchemeForResponses()
        {
            var schema = JsonConvert.DeserializeObject<JsonSchemaModel>(File.ReadAllText("Schemes/responses.json"));

            var result = schema.Definitions.Keys.Select(StringExtensions.NameToCamel).ToList();
            //result.ForEach(Console.WriteLine);
            //return result;

            foreach ((var title, JObject jObject) in schema.Definitions)
            {
                Console.WriteLine(title);
                JsonObjectHandler.CheckType(jObject);
            }

            return null;
        }
    }
}