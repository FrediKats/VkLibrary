using Newtonsoft.Json;

namespace VkLibrary.Core.Types.Wall
{
    /// <summary>
    /// API PostSource object.
    /// </summary>
    public class PostSource
    {
        /// <summary>
        /// Platform name
        /// </summary>
        [JsonProperty("platform")]
        public string Platform { get; set; }

        /// <summary>
        /// Additional data
        /// </summary>
        [JsonProperty("data")]
        public string Data { get; set; }

        /// <summary>
        /// URL to an external site used to publish the post
        /// </summary>
        [JsonProperty("url")]
        public string Url { get; set; }

        /// <summary>
        /// Type of post source
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }
    }
}