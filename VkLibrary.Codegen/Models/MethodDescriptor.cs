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

        public ICustomCaseTitle Scope { get; set; }

        public MethodDescriptor(MethodData methodData)
        {
            (string scope, string camelTitle) = methodData.Name.SplitFirstPart();
            Scope = CamelCaseTitle.Of(scope);
            Title = UndefinedCaseTitle.Of(methodData.Name, camelTitle.TitleToCamelCaseStyle());
            Descriptor = methodData.Description;
            ResponseType = TypeParser.ParseType(methodData.Responses["response"]);
            MethodParameterDescriptors = methodData.Parameters.Select(MethodParameterDescriptor.Create).ToArray();
        }
    }
}