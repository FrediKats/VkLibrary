using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace VkLibrary.Core.Objects
{
    public class AdsAccesses
    {
        ///<summary>
        /// Client ID
        ///</summary>
        [JsonProperty("client_id")]
        public String ClientId { get; set; }
        [JsonProperty("role")]
        public AdsAccessRole Role { get; set; }
    }
}