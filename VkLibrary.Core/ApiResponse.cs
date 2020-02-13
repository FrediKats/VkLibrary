using Newtonsoft.Json;

namespace VkApi.Wrapper
{
    /// <summary>
    /// Main API response object that helds all information.
    /// </summary>
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