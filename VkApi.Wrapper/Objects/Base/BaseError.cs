using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace VkApi.Wrapper.Objects
{
    public class BaseError
    {
        ///<summary>
        /// Error code
        ///</summary>
        [JsonProperty("error_code")]
        public int ErrorCode { get; set; }

        ///<summary>
        /// Error message
        ///</summary>
        [JsonProperty("error_msg")]
        public String ErrorMsg { get; set; }
        [JsonProperty("request_params")]
        public BaseRequestParam[] RequestParams { get; set; }
    }
}