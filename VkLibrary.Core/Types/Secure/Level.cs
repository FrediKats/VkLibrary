using Newtonsoft.Json;

namespace VkLibrary.Core.Types.Secure
{
    /// <summary>
    /// API Level object.
    /// </summary>
    public class Level
    {
        /// <summary>
        /// Level
        /// </summary>
        [JsonProperty("level")]
        public int? LevelCode { get; set; }

        /// <summary>
        /// User ID
        /// </summary>
        [JsonProperty("uid")]
        public int? Uid { get; set; }
    }
}