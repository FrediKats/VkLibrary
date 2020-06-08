using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace VkApi.Wrapper.Objects
{
    public class AdsTargSettings : AdsCriteria
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