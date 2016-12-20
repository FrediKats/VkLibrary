using System;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace VkLib.Types.Ads 
{
    public class TargStats
    {
        /// <summary>
        /// Audience
        /// </summary>
        [JsonProperty("audience_count")]
        public int? AudienceCount_ { get; set; }

        /// <summary>
        /// Recommended CPC value
        /// </summary>
        [JsonProperty("recommended_cpc")]
        public uint? RecommendedCpc_ { get; set; }

        /// <summary>
        /// Recommended CPM value
        /// </summary>
        [JsonProperty("recommended_cpm")]
        public uint? RecommendedCpm_ { get; set; }

    }
}
