using Newtonsoft.Json;

namespace VkLibrary.Core.Types.Ads
{
    /// <summary>
    /// API FloodStats object.
    /// </summary>
    public class FloodStats
    {
        /// <summary>
        /// Time to refresh in seconds
        /// </summary>
        [JsonProperty("refresh")]
        public int? Refresh { get; set; }

        /// <summary>
        /// Requests left
        /// </summary>
        [JsonProperty("left")]
        public int? Left { get; set; }
    }
}