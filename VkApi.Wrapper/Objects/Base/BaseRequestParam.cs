using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace VkApi.Wrapper.Objects
{
    public class BaseRequestParam
    {
        ///<summary>
        /// Parameter name
        ///</summary>
        [JsonProperty("key")]
        public String Key { get; set; }

        ///<summary>
        /// Parameter value
        ///</summary>
        [JsonProperty("value")]
        public String Value { get; set; }
    }
}