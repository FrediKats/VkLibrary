using Newtonsoft.Json;

namespace VkLibrary.Core.Types.Secure
{
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