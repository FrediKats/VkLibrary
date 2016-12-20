using System;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace VkLib.Types.Base 
{
    public class Error
    {
        /// <summary>
        /// Property
        /// </summary>
        [JsonProperty("request_params")]
        public IEnumerable<VkLib.Types.Base.RequestParam> RequestParams { get; set; }

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
