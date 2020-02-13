using Newtonsoft.Json;

namespace VkApi.Wrapper.Types.Ads
{
    public class AdsTargSettings
    {
        ///<summary>
        /// Ad ID
        ///</summary>
        [JsonProperty("id")]
        public int Id { get; set; }

        ///<summary>
        /// Campaign ID
        ///</summary>
        [JsonProperty("campaign_id")]
        public int CampaignId { get; set; }
    }
}