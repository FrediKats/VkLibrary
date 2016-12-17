using System;
using Newtonsoft.Json;

namespace VkLib.Types.Ads 
{
    public class TargStats
    {
        /// <summary>
        /// Recommended CPC value
        /// </summary>
        [JsonProperty("recommended_cpc")]
        public uint? RecommendedCpc { get; set; }

        /// <summary>
        /// Recommended CPM value
        /// </summary>
        [JsonProperty("recommended_cpm")]
        public uint? RecommendedCpm { get; set; }

        /// <summary>
        /// Audience
        /// </summary>
        [JsonProperty("audience_count")]
        public int? AudienceCount { get; set; }

    }
}
