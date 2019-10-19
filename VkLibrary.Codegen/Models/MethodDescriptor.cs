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
            string[] splited = methodData.Name.Split('.', 2);
            Scope = CamelCaseTitle.Of(splited.First());
            CamelCaseTitle camelTitle = CamelCaseTitle.Of(splited.ElementAt(1));

            //TODO: hack
            Title = UndefinedCaseTitle.Of(methodData.Name, camelTitle.Value);
            Descriptor = methodData.Description;
            ResponseType = TypeParser.ParseType(methodData.Responses["response"]);
            MethodParameterDescriptors = methodData.Parameters.Select(MethodParameterDescriptor.Create).ToArray();
        }
    }
}