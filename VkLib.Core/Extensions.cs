using System;
using System.Collections.Generic;

namespace VkLib
{
    /// <summary>
    ///     Extension methods.
    /// </summary>
    public static class Extensions
    {
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

    /// <summary>
    ///     Represents API exception - exception that holds
    ///     ApiError with Exception data.
    /// </summary>
    public class ApiException : Exception
    {
        private readonly ApiError _apiError;

        public ApiException(ApiError apiError) => _apiError = apiError;

        public ApiError GetApiError() => _apiError;
    }
}