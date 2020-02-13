using System;
using Newtonsoft.Json;

namespace VkApi.Wrapper.Responses.Streaming
{
    public class StreamingGetServerUrlResponse
    {
        ///<summary>
        /// Server host
        ///</summary>
        [JsonProperty("endpoint")]
        public String Endpoint { get; set; }

        ///<summary>
        /// Access key
        ///</summary>
        [JsonProperty("key")]
        public String Key { get; set; }
    }
}