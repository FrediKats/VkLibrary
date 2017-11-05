using System.Collections;
using System.Globalization;
using System.Linq;

namespace VkLibrary.Core
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
            var tempList = (from object o in enumerable select o).ToList();
            return string.Join(",", tempList);
        }
    }
}