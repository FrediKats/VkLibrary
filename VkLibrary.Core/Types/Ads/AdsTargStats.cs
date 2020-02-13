using Newtonsoft.Json;

namespace VkApi.Wrapper.Types.Ads
{
    public class AdsTargStats
    {
        ///<summary>
        /// Audience
        ///</summary>
        [JsonProperty("audience_count")]
        public int AudienceCount { get; set; }

        ///<summary>
        /// Recommended CPC value
        ///</summary>
        [JsonProperty("recommended_cpc")]
        public double RecommendedCpc { get; set; }

        ///<summary>
        /// Recommended CPM value
        ///</summary>
        [JsonProperty("recommended_cpm")]
        public double RecommendedCpm { get; set; }
    }
}