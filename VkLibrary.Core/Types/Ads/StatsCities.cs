using Newtonsoft.Json;

namespace VkLibrary.Core.Types.Ads
{
    public class StatsCities
    {
        /// <summary>
        /// City ID
        /// </summary>
        [JsonProperty("value")]
        public int? Value { get; set; }

        /// <summary>
        /// City name
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Impressions rate
        /// </summary>
        [JsonProperty("impressions_rate")]
        public uint? ImpressionsRate { get; set; }

        /// <summary>
        /// Clicks rate
        /// </summary>
        [JsonProperty("clicks_rate")]
        public uint? ClicksRate { get; set; }
    }
}