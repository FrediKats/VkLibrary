using Newtonsoft.Json;

namespace VkLibrary.Core.Types.Ads
{
    /// <summary>
    /// API Ad object.
    /// </summary>
    public class Ad
    {
        /// <summary>
        /// Ad ID
        /// </summary>
        [JsonProperty("id")]
        public int? Id { get; set; }

        /// <summary>
        /// Cost of 1000 impressions, kopecks
        /// </summary>
        [JsonProperty("cpm")]
        public int? Cpm { get; set; }

        /// <summary>
        /// Ad platform
        /// </summary>
        [JsonProperty("ad_platform")]
        public string AdPlatform { get; set; }

        /// <summary>
        /// Campaign ID
        /// </summary>
        [JsonProperty("campaign_id")]
        public int? CampaignId { get; set; }

        /// <summary>
        /// Ad format
        /// </summary>
        [JsonProperty("ad_format")]
        public int? AdFormat { get; set; }

        /// <summary>
        /// Category ID
        /// </summary>
        [JsonProperty("category1_id")]
        public int? Category1Id { get; set; }

        /// <summary>
        /// Ad title
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Impressions limit
        /// </summary>
        [JsonProperty("impressions_limit")]
        public int? ImpressionsLimit { get; set; }

        /// <summary>
        /// Information whether the ad is a video
        /// </summary>
        [JsonProperty("video")]
        public int? Video { get; set; }

        /// <summary>
        /// Information whether impressions are limited
        /// </summary>
        [JsonProperty("impressions_limited")]
        public int? ImpressionsLimited { get; set; }

        /// <summary>
        /// Additional category ID
        /// </summary>
        [JsonProperty("category2_id")]
        public int? Category2Id { get; set; }

        /// <summary>
        /// Cost type
        /// </summary>
        [JsonProperty("cost_type")]
        public int? CostType { get; set; }

        /// <summary>
        /// Ad atatus
        /// </summary>
        [JsonProperty("status")]
        public int? Status { get; set; }

        /// <summary>
        /// Cost of a click, kopecks
        /// </summary>
        [JsonProperty("cpc")]
        public int? Cpc { get; set; }

        /// <summary>
        /// Information whether disclaimer is enabled
        /// </summary>
        [JsonProperty("disclaimer_supplements")]
        public int? DisclaimerSupplements { get; set; }

        /// <summary>
        /// Total limit
        /// </summary>
        [JsonProperty("all_limit")]
        public int? AllLimit { get; set; }

        /// <summary>
        /// Information whether disclaimer is enabled
        /// </summary>
        [JsonProperty("disclaimer_medical")]
        public int? DisclaimerMedical { get; set; }

        /// <summary>
        /// Information whether disclaimer is enabled
        /// </summary>
        [JsonProperty("disclaimer_specialist")]
        public int? DisclaimerSpecialist { get; set; }

        /// <summary>
        /// Review status
        /// </summary>
        [JsonProperty("approved")]
        public int? Approved { get; set; }
    }
}