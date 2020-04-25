using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace VkApi.Wrapper.Objects
{
    public class AdsTargStats
    {
        ///<summary>
        /// Audience
        ///</summary>
        [JsonProperty("audience_count")]
        public int AudienceCount { get; set; }

        ///<summary>
        /// Recommended CPC value for 50% reach (old format)
        ///</summary>
        [JsonProperty("recommended_cpc")]
        public double RecommendedCpc { get; set; }

        ///<summary>
        /// Recommended CPM value for 50% reach (old format)
        ///</summary>
        [JsonProperty("recommended_cpm")]
        public double RecommendedCpm { get; set; }

        ///<summary>
        /// Recommended CPC value for 50% reach
        ///</summary>
        [JsonProperty("recommended_cpc_50")]
        public double RecommendedCpc50 { get; set; }

        ///<summary>
        /// Recommended CPM value for 50% reach
        ///</summary>
        [JsonProperty("recommended_cpm_50")]
        public double RecommendedCpm50 { get; set; }

        ///<summary>
        /// Recommended CPC value for 70% reach
        ///</summary>
        [JsonProperty("recommended_cpc_70")]
        public double RecommendedCpc70 { get; set; }

        ///<summary>
        /// Recommended CPM value for 70% reach
        ///</summary>
        [JsonProperty("recommended_cpm_70")]
        public double RecommendedCpm70 { get; set; }

        ///<summary>
        /// Recommended CPC value for 90% reach
        ///</summary>
        [JsonProperty("recommended_cpc_90")]
        public double RecommendedCpc90 { get; set; }

        ///<summary>
        /// Recommended CPM value for 90% reach
        ///</summary>
        [JsonProperty("recommended_cpm_90")]
        public double RecommendedCpm90 { get; set; }
    }
}