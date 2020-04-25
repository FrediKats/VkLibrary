using System.Linq;
using VkLibrary.Codegen.Tools;

namespace VkLibrary.Codegen.Types.TitleCase
{
    public class CamelCaseTitle : ICustomCaseTitle
    {
        private readonly string _originalValue;
        private readonly bool _isLower;
        private readonly string _value;

        public CamelCaseTitle(string value, bool isLower = false)
        {
            _originalValue = value;
            _isLower = isLower;
            _value = isLower ? _originalValue.TitleToLowerCamelCaseStyle() : _originalValue.TitleToCamelCaseStyle();
        }


        public string ToSharpString()
        {
            string[] keywords = {
                "abstract", "as", "base", "bool", "break",
                "byte", "case", "catch", "char", "checked",
                "class", "const", "continue", "decimal", "default",
                "delegate", "do", "double", "else", "enum",
                "event", "explicit", "extern", "false", "finally",
                "fixed", "float", "for", "foreach", "goto",
                "if", "implicit", "in", "int", "interface",
                "internal", "is", "lock", "long", "namespace",
                "new", "null", "object", "operator", "out",
                "override", "params", "private", "protected", "public",
                "readonly", "ref", "return", "sbyte", "sealed",
                "short", "sizeof", "stackalloc", "static", "string",
                "struct", "switch", "this", "throw", "true",
                "try", "typeof", "uint", "ulong", "unchecked",
                "unsafe", "ushort", "using", "var", "virtual",
                "void", "volatile", "while"
            };

            if (char.IsNumber(_value.First()))
            {
                Log.Instance.Message($"Replace name: [{_value}] => [_{_value}]");
                return $"_{_value}";
            }

            if (_isLower && keywords.Contains(_value.ToLower()))
            {
                Log.Instance.Message($"Replace variable name: [{_value}] => [@{_value}]");
                return $"@{_value}";
            }

            //TODO: hack
            return _value;
        }

        public string ToOriginalString()
        {
            return _originalValue;
        }

        public static CamelCaseTitle Of(string value, bool isLower = false)
        {
            return new CamelCaseTitle(value, isLower);
        }

        public override string ToString()
        {
            return ToSharpString();
        }
    }
}