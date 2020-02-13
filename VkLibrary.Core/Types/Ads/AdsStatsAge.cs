using System;
using Newtonsoft.Json;

namespace VkApi.Wrapper.Types.Ads
{
    public class AdsStatsAge
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

        ///<summary>
        /// Age interval
        ///</summary>
        [JsonProperty("value")]
        public String Value { get; set; }
    }
}