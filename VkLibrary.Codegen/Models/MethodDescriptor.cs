using System.Linq;
using VkLibrary.Codegen.JsonModel;
using VkLibrary.Codegen.Tools;
using VkLibrary.Codegen.Types.TitleCase;

namespace VkLibrary.Codegen.Models
{
    public class MethodDescriptor
    {
        public ICustomCaseTitle Title { get; set; }
        public string Descriptor { get; set; }
        public ICustomCaseTitle ResponseType { get; set; }
        public MethodParameterDescriptor[] MethodParameterDescriptors { get; set; }

        public MethodDescriptor(MethodData methodData)
        {
            Title = CamelCaseTitle.Of(methodData.Name);
            Descriptor = methodData.Description;
            ResponseType = TypeParser.ParseType(methodData.Responses["response"]);
            MethodParameterDescriptors = methodData.Parameters.Select(MethodParameterDescriptor.Create).ToArray();
        }
    }
}