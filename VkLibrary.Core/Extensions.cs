using System.Collections.Generic;

namespace VkLibrary.Core
{
    /// <summary>
    /// Extension methods.
    /// </summary>
    public static class Extensions
    {
        /// <summary>
        /// Converts certain string to API string based on
        /// Vkontakte APU syntax rules.
        /// </summary>
        /// <param name="variable">Object to convert</param>
        /// <returns>Stringified value</returns>
        internal static string ToApiString(this object variable)
        {
            // Check for booleans.
            var type = variable.GetType();
            if (type == typeof(bool)) return (bool) variable ? "1" : "0";

            // Check for sequences.
            var enumerable = variable as IEnumerable<object>;
            return enumerable != null
                ? string.Join(",", enumerable)
                : variable.ToString();
        }
    }
}