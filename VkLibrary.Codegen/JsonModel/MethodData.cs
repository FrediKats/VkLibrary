using Newtonsoft.Json.Linq;

namespace VkLibrary.Codegen.JsonModel
{
    public class MethodData
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public MethodParameterData[] Parameters { get; set; }
        public JObject Responses { get; set; }

        public MethodData()
        {
            Parameters = new MethodParameterData[0];
        }
    }
}