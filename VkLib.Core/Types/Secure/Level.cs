using Newtonsoft.Json;

namespace VkLib.Types.Secure
{
    public class Level
    {
        /// <summary>
        ///     Level
        /// </summary>
        [JsonProperty("level")]
        public int? LevelCode { get; set; }

        /// <summary>
        ///     User ID
        /// </summary>
        [JsonProperty("uid")]
        public int? Uid { get; set; }
    }
}