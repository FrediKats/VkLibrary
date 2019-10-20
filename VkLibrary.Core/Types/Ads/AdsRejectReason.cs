using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace VkLibrary.Core.Objects
{
    public class AdsRejectReason
    {
        ///<summary>
        /// Comment text
        ///</summary>
        [JsonProperty("comment")]
        public String Comment { get; set; }
        [JsonProperty("rules")]
        public AdsRules[] Rules { get; set; }
    }
}