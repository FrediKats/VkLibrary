using Newtonsoft.Json;
using VkLibrary.Core.Objects;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace VkLibrary.Core.Responses
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