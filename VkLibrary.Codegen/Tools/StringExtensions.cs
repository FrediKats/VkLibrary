using System.Globalization;
using System.Linq;

namespace VkLibrary.Codegen.Tools
{
    public static class StringExtensions
    {
        public static string NameToCamel(this string schemeObjectTitle)
        {
            return schemeObjectTitle
                .Split("_")
                //.Skip(1)
                .Select(s => char.ToUpper(s[0]) + s.Substring(1))
                .Aggregate((a, b) => a + b);
        }
    }
}