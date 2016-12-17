using System;
using Newtonsoft.Json;

namespace VkLib.Types.Ads 
{
    public class StatsSex
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
        /// Sex
        /// </summary>
        [JsonProperty("value")]
        public string Value { get; set; }

    }
}
