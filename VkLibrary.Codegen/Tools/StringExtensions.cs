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

        public static (string Scope, string CamelTitle) SplitWithScope(this string snakeStyle)
        {
            var split = snakeStyle.Split(new[] {'_', '.'}, 2);

            if (split.Length == 1)
                return (null, snakeStyle);

            return (split[0], split[1]);
        }
    }
}