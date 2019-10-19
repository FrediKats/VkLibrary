using System.Linq;
using VkLibrary.Codegen.Tools;

namespace VkLibrary.Codegen.Types.TitleCase
{
    public class CamelCaseTitle : ICustomCaseTitle
    {
        public CamelCaseTitle(string value)
        {
            OriginalValue = value;
        }

        public string OriginalValue { get; }
        public string Value => OriginalValue.TitleToCamelCaseStyle();

        public string ToSharpString()
        {
            if (!char.IsNumber(Value.First()))
                return Value;

            //TODO: hack
            Log.Instance.Message($"Replace variable name: [{Value}] => [_{Value}]");
            return $"_{Value}";
        }

        public string ToOriginalString()
        {
            return OriginalValue;
        }

        public static CamelCaseTitle Of(string value)
        {
            return new CamelCaseTitle(value);
        }

        public override string ToString()
        {
            return ToSharpString();
        }
    }
}