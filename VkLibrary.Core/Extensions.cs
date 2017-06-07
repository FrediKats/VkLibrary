using System.Collections;
using System.Linq;

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
        public static string ToApiString(this object variable)
        {
            // Check for booleans.
            var type = variable.GetType();
            if (type == typeof(bool)) return (bool) variable ? "1" : "0";

            // Check for sequences.
            var enumerable = variable as IEnumerable;
            if (enumerable == null || variable is string)
                return variable.ToString();

            // Check-convert.
            var tempList = (from object o in enumerable select o).ToList();
            return string.Join(",", tempList);
        }
    }
}