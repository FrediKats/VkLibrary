using System.Collections.Generic;
using Newtonsoft.Json.Linq;

namespace VkLibrary.Codegen.JsonModel
{
    public class JsonSchemaModel
    {
        public string Title { get; set; }
        public Dictionary<string, JObject> Definitions { get; set; }
    }
}