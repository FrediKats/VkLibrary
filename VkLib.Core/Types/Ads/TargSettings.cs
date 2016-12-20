using System;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace VkLib.Types.Ads 
{
    public class TargSettings : VkLib.Types.Ads.Criteria
    {
        /// <summary>
        /// Ad ID
        /// </summary>
        [JsonProperty("id")]
        public int? Id { get; set; }

        /// <summary>
        /// Campaign ID
        /// </summary>
        [JsonProperty("campaign_id")]
        public int? CampaignId_ { get; set; }

    }
}
