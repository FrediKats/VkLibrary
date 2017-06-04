using Newtonsoft.Json;

namespace VkLibrary.Core
{
    /// <summary>
    /// Main API response object that helds all information.
    /// </summary>
    /// <typeparam name="T">Generic</typeparam>
    [JsonObject]
    public class ApiResponse<T>
    {
        /// <summary>
        /// Response of a given type.
        /// </summary>
        [JsonProperty("response")]
        public T Response { get; set; }

        /// <summary>
        /// Error got from API. Is NULL when everything is OK.
        /// </summary>
        [JsonProperty("error")]
        public ApiError Error { get; set; }
    }
}