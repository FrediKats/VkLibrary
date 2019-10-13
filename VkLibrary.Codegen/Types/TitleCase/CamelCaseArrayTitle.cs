using VkLibrary.Codegen.Tools;

namespace VkLibrary.Codegen.Types.TitleCase
{
    public class CamelCaseArrayTitle : ICustomCaseTitle
    {
        public CamelCaseArrayTitle(string value)
        {
            OriginalValue = $"{value}[]";
            Value = $"{value.TitleToCamelCaseStyle()}[]";
        }

        public CamelCaseArrayTitle(string originalValue, string value)
        {
            OriginalValue = $"{originalValue}[]";
            Value = $"{value}[]";
        }

        public string OriginalValue { get; }
        public string Value { get; }

        public string ToSharpString() => Value;
        public string ToOriginalString() => OriginalValue;

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