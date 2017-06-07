using System;

namespace VkLibrary.Core
{
    /// <summary>
    /// Represents API exception - exception that holds
    /// ApiError with Exception information.
    /// </summary>
    public class ApiException : Exception
    {
        private readonly ApiError _apiError;

        /// <summary>
        /// Creates a new instance of ApiException to hold ApiError.
        /// </summary>
        /// <param name="apiError">ApiError info</param>
        public ApiException(ApiError apiError) => _apiError = apiError;

        /// <summary>
        /// Returns API exception container that holds 
        /// relevant exception information.
        /// </summary>
        /// <returns></returns>
        public ApiError GetApiError() => _apiError;
    }
}
