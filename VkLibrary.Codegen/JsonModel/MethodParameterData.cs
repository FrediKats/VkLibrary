using Newtonsoft.Json.Linq;

namespace VkLibrary.Codegen.JsonModel
{
    public class MethodParameterData
    {
        public string Name { get; set; }
        public string Descriptor { get; set; }
        public string Type { get; set; }
        public bool IsRequired { get; set; }
        public JObject Items { get; set; }

    }
}