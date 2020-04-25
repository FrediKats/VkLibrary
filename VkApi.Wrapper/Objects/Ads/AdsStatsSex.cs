using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace VkApi.Wrapper.Objects
{
    public class AdsStatsSex
    {
        ///<summary>
        /// Clicks rate
        ///</summary>
        [JsonProperty("clicks_rate")]
        public double ClicksRate { get; set; }

        ///<summary>
        /// Impressions rate
        ///</summary>
        [JsonProperty("impressions_rate")]
        public double ImpressionsRate { get; set; }
        [JsonProperty("value")]
        public AdsStatsSexValue Value { get; set; }
    }
}