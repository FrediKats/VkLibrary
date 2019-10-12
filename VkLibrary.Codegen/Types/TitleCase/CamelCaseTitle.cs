using System.Linq;

namespace VkLibrary.Codegen.Types.TitleCase
{
    public class CamelCaseTitle : ICustomCaseTitle
    {
        public CamelCaseTitle(string value)
        {
            OriginalValue = value;
        }

        public string OriginalValue { get; }
        public string Value => NameToCamel();

        public static CamelCaseTitle Of(string value)
        {
            return new CamelCaseTitle(value);
        }

        public string NameToCamel()
        {
            return OriginalValue
                .Split("_")
                .Select(s => char.ToUpper(s[0]) + s.Substring(1))
                .Aggregate((a, b) => a + b);
        }

        public override string ToString()
        {
            return Value;
        }
    }
}