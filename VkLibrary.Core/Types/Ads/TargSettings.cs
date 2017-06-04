using Newtonsoft.Json;

namespace VkLibrary.Core.Types.Ads
{
    public class TargSettings : Criteria
    {
        /// <summary>
        /// Campaign ID
        /// </summary>
        [JsonProperty("campaign_id")]
        public int? CampaignId { get; set; }

        /// <summary>
        /// Ad ID
        /// </summary>
        [JsonProperty("id")]
        public int? Id { get; set; }
    }
}