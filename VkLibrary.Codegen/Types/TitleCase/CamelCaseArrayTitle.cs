using VkLibrary.Codegen.Tools;

namespace VkLibrary.Codegen.Types.TitleCase
{
    public class CamelCaseArrayTitle : ICustomCaseTitle
    {
        private readonly string _originalValue;
        private readonly string _value;

        public CamelCaseArrayTitle(string value)
        {
            _originalValue = $"{value}[]";
            _value = $"{value.TitleToCamelCaseStyle()}[]";
        }

        public CamelCaseArrayTitle(string originalValue, string value)
        {
            _originalValue = $"{originalValue}[]";
            _value = $"{value}[]";
        }

        public string ToSharpString()
        {
            return _value;
        }

        public string ToOriginalString()
        {
            return _originalValue;
        }

        public static CamelCaseArrayTitle Of(ICustomCaseTitle innerType)
        {
            return new CamelCaseArrayTitle(innerType.ToOriginalString(), innerType.ToSharpString());
        }

        public override string ToString()
        {
            return ToSharpString();
        }
    }
}