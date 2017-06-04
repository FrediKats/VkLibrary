using Newtonsoft.Json;

namespace VkLibrary.Core.Types.Messages
{
    public class LongpollParams
    {
        /// <summary>
        /// Server URL
        /// </summary>
        [JsonProperty("server")]
        public string Server { get; set; }

        /// <summary>
        /// Timestamp
        /// </summary>
        [JsonProperty("ts")]
        public int? Ts { get; set; }

        /// <summary>
        /// Key
        /// </summary>
        [JsonProperty("key")]
        public string Key { get; set; }
    }
}