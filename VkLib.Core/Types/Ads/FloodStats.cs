using System;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace VkLib.Types.Ads 
{
    public class FloodStats
    {
        /// <summary>
        /// Time to refresh in seconds
        /// </summary>
        [JsonProperty("refresh")]
        public int? Refresh { get; set; }

        /// <summary>
        /// Requests left
        /// </summary>
        [JsonProperty("left")]
        public int? Left { get; set; }

    }
}
