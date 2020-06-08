using System;
using System.Collections;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;

namespace VkApi.Wrapper
{
    /// <summary>
    /// Extension methods.
    /// </summary>
    public static class Extensions
    {
        /// <summary>
        /// Converts objects to API strings based on Vkontakte API syntax rules. 
        /// For example: true -> 1; false -> 0; string -> string; 
        /// seq of strings -> string1, string2, ...stringN.
        /// </summary>
        /// <param name="variable">Object to convert</param>
        /// <returns>Stringified value</returns>
        public static string ToApiString(this object variable)
        {
            // Check for booleans.
            var type = variable.GetType();
            if (type == typeof(bool)) return (bool) variable ? "1" : "0";

            // Check for doubles.
            if (variable is double @double) return @double.ToString(CultureInfo.InvariantCulture);

            // Check for sequences.
            if (!(variable is IEnumerable enumerable) || variable is string)
                return variable.ToString();

            // Check-convert.
            var tempList = (from object o in enumerable select ElementToString(o)).ToList();
            return string.Join(",", tempList);
        }

        private static string ElementToString(object variable)
        {
            Type type = variable.GetType();
            if (!type.GetTypeInfo().IsEnum)
                return variable.ToString();

            String attribute = type
                .GetTypeInfo()
                .DeclaredMembers
                .SingleOrDefault(x => x.Name == variable.ToString())
                ?.GetCustomAttribute<EnumMemberAttribute>(false)
                ?.Value;

            return attribute ?? variable.ToString();
        }
    }
}