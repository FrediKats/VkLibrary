using VkLibrary.Codegen.JsonModel;
using VkLibrary.Codegen.Tools;
using VkLibrary.Codegen.Types.TitleCase;

namespace VkLibrary.Codegen.Models
{
    public class MethodParameterDescriptor
    {
        public ICustomCaseTitle Title { get; set; }
        public string Descriptor { get; set; }
        public ICustomCaseTitle Type { get; set; }
        public bool IsRequired { get; set; }

        public static MethodParameterDescriptor Create(MethodParameterData parameterData)
        {
            return new MethodParameterDescriptor
            {
                Title =  CamelCaseTitle.Of(parameterData.Title),
                Descriptor =  parameterData.Descriptor,
                IsRequired = parameterData.IsRequired,
                Type = TypeParser.ParseType(parameterData.Type)
            };
        }

        //TODO: "enum" : 
    }
}