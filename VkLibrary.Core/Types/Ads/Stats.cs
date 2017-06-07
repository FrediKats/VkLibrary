using Newtonsoft.Json;

namespace VkLibrary.Core.Types.Ads
{
    /// <summary>
    /// API Stats object.
    /// </summary>
    public class Stats
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
        public StatsFormat StatsFormat { get; set; }

        /// <summary>
        /// Object ID
        /// </summary>
        [JsonProperty("id")]
        public int? Id { get; set; }
    }
}