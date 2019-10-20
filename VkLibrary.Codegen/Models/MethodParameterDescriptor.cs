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
            ICustomCaseTitle type = parameterData.Type == "array"
                ? CamelCaseArrayTitle.Of(TypeParser.ParseType(parameterData.Items))
                : TypeParser.MatchDefaultType(parameterData.Type);

            return new MethodParameterDescriptor
            {
                Title =  CamelCaseTitle.Of(parameterData.Name, true),
                Descriptor =  parameterData.Descriptor,
                IsRequired = parameterData.IsRequired,
                Type = type
            };
        }

        //TODO: enum arguments like
        //{
        //    "name": "filters",
        //    "description": "Filters to apply: 'youtube' — return YouTube videos only, 'vimeo' — return Vimeo videos only, 'short' — return short videos only, 'long' — return long videos only",
        //    "type": "array",
        //    "items": {
        //        "type": "string",
        //        "enum": [
        //        "youtube",
        //        "vimeo",
        //        "short",
        //        "long"
        //            ]
        //    }
        //},
    }
}