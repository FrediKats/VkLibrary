using System;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace VkLib.Types.Ads 
{
    public class RejectReason
    {
        /// <summary>
        /// Comment text
        /// </summary>
        [JsonProperty("comment")]
        public string Comment { get; set; }

        /// <summary>
        /// Property
        /// </summary>
        [JsonProperty("rules")]
        public IEnumerable<VkLib.Types.Ads.Rules> Rules { get; set; }

    }
}
