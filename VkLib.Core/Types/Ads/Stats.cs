using System;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace VkLib.Types.Ads 
{
    public class Stats
    {
        /// <summary>
        /// Property
        /// </summary>
        [JsonProperty("stats")]
        public VkLib.Types.Ads.StatsFormat Stats_ { get; set; }

        /// <summary>
        /// Property
        /// </summary>
        [JsonProperty("type")]
        public string Type_ { get; set; }

        /// <summary>
        /// Object ID
        /// </summary>
        [JsonProperty("id")]
        public int? Id_ { get; set; }

    }
}
