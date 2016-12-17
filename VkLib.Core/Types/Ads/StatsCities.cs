using System;
using Newtonsoft.Json;

namespace VkLib.Types.Ads 
{
    public class StatsCities
    {
        /// <summary>
        /// Clicks rate
        /// </summary>
        [JsonProperty("clicks_rate")]
        public uint? ClicksRate { get; set; }

        /// <summary>
        /// Impressions rate
        /// </summary>
        [JsonProperty("impressions_rate")]
        public uint? ImpressionsRate { get; set; }

        /// <summary>
        /// City name
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// City ID
        /// </summary>
        [JsonProperty("value")]
        public int? Value { get; set; }

    }
}
