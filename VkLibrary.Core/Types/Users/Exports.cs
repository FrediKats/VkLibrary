using Newtonsoft.Json;

namespace VkLibrary.Core.Types.Users
{
    /// <summary>
    /// API Exports object.
    /// </summary>
    public class Exports
    {
        /// <summary>
        /// Property
        /// </summary>
        [JsonProperty("twitter")]
        public int? Twitter { get; set; }

        /// <summary>
        /// Property
        /// </summary>
        [JsonProperty("facebook")]
        public int? Facebook { get; set; }

        /// <summary>
        /// Property
        /// </summary>
        [JsonProperty("livejournal")]
        public int? Livejournal { get; set; }
    }
}