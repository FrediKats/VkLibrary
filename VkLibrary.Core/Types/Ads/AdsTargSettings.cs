using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace VkLibrary.Core.Objects
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