using System;
using Newtonsoft.Json;

namespace VkLib.Types.Ads 
{
    public class Stats
    {
        /// <summary>
        /// Property
        /// </summary>
        [JsonProperty("type")]
        public ObjectType Type { get; set; }

        /// <summary>
        /// Object ID
        /// </summary>
        [JsonProperty("id")]
        public int? Id { get; set; }

        /// <summary>
        /// Property
        /// </summary>
        [JsonProperty("stats")]
        public StatsFormat Stats { get; set; }

    }
}
