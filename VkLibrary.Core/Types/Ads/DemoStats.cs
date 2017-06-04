using Newtonsoft.Json;

namespace VkLibrary.Core.Types.Ads
{
    public class DemoStats
    {
        /// <summary>
        /// Property
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }

        /// <summary>
        /// Property
        /// </summary>
        [JsonProperty("stats")]
        public DemostatsFormat Stats { get; set; }

        /// <summary>
        /// Object ID
        /// </summary>
        [JsonProperty("id")]
        public int? Id { get; set; }
    }
}