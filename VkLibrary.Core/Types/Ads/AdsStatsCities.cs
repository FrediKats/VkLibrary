using System;
using Newtonsoft.Json;

namespace VkApi.Wrapper.Types.Ads
{
    public class AdsStatsCities
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
        /// City name
        ///</summary>
        [JsonProperty("name")]
        public String Name { get; set; }

        ///<summary>
        /// City ID
        ///</summary>
        [JsonProperty("value")]
        public int Value { get; set; }
    }
}