using System;
using Newtonsoft.Json;

namespace VkApi.Wrapper.Types.Base
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