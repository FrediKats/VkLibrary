using System;
using System.Linq;

namespace VkLibrary.Codegen.Tools
{
    public static class StringExtensions
    {
        public static string ToLogString<T>(this T instance)
        {
            return instance.ToString().Replace(Environment.NewLine, " ");
        }

        public static string TitleToCamelCaseStyle(this string spakeStyle)
        {
            return spakeStyle
                .Split('_', ' ')
                .Select(s => char.ToUpper(s[0]) + s.Substring(1))
                .Aggregate((a, b) => a + b);
        }
    }
}