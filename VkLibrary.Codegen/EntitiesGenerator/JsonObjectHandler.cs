using System;
using Newtonsoft.Json.Linq;

namespace VkLibrary.Codegen.EntitiesGenerator
{
    public class JsonObjectHandler
    {
        public static void CheckType(JObject schemeObject)
        {
            if (!schemeObject.ContainsKey("type"))
                throw new ArgumentException($"Object don't contains type: {schemeObject}");

            var type = schemeObject["type"].Value<string>();
            switch (type)
            {
                case "object":
                    break;
                case "enum":
                    break;
                default:
                    throw new ArgumentException($"Invalid type: {type}");
            }
        }
    }
}