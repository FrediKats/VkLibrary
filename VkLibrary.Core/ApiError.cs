using Newtonsoft.Json;

namespace VkLibrary.Core
{
    /// <summary>
    /// API error class.
    /// </summary>
    [JsonObject]
    public class ApiError
    {
        /// <summary>
        /// API error code.
        /// </summary>
        [JsonProperty("error_code")]
        public int Code { get; set; }

        /// <summary>
        /// API error title.
        /// </summary>
        [JsonProperty("error_msg")]
        public string ErrorMessage { get; set; }
    }
}
