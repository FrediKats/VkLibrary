using System;
using Newtonsoft.Json;

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
        public IEnumerable<Rules> Rules { get; set; }

    }
}
