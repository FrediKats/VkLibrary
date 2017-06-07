using System.Collections.Generic;
using Newtonsoft.Json;

namespace VkLibrary.Core.Types.Base
{
    /// <summary>
    /// API Error object.
    /// </summary>
    public class Error
    {
        /// <summary>
        /// Property
        /// </summary>
        [JsonProperty("request_params")]
        public IEnumerable<RequestParam> RequestParams { get; set; }

        /// <summary>
        /// Error message
        /// </summary>
        [JsonProperty("error_msg")]
        public string ErrorMsg { get; set; }

        /// <summary>
        /// Error code
        /// </summary>
        [JsonProperty("error_code")]
        public int? ErrorCode { get; set; }
    }
}