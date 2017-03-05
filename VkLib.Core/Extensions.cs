using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Popups;

namespace VkLib
{
    public static class Extensions
    {
        public static string ToApiString(this object variable)
        {
            // Check for booleans.
            Type type = variable.GetType();
            if (type == typeof(bool)) return (bool)variable ? "1" : "0";

            // Check for sequences.
            IEnumerable<object> enumerable = variable as IEnumerable<object>;
            if (enumerable != null) return string.Join(",", enumerable);

            return variable.ToString();
        }

    }

    public class ApiException : Exception
    {
        private ApiError apiError;

        public ApiException(ApiError apiError)
        {
            this.apiError = apiError;
        }

        public ApiError GetApiError()
        {
            return this.apiError;
        }
    }
}
