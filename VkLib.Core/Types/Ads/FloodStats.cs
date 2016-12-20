using System;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace VkLib.Types.Ads 
{
    public class FloodStats
    {
        /// <summary>
        /// Requests left
        /// </summary>
        [JsonProperty("left")]
        public int? Left { get; set; }

        /// <summary>
        /// Time to refresh in seconds
        /// </summary>
        [JsonProperty("refresh")]
        public int? Refresh { get; set; }

    }
}
