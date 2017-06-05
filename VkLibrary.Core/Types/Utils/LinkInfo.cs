using Newtonsoft.Json;

namespace VkLibrary.Core.Types.Utils
{
    public class LinkInfo
    {
        /// <summary>
        /// Shotened url.
        /// </summary>
        [JsonProperty("short_url")]
        public string ShortUrl { get; set; }

        /// <summary>
        /// Full URL. 
        /// </summary>
        [JsonProperty("url")]
        public string Url { get; set; }

        /// <summary>
        /// Link key (characters after "vk.cc"); 
        /// </summary>
        [JsonProperty("key")]
        public string Key { get; set; }

        /// <summary>
        /// Access key for private stats.
        /// </summary>
        [JsonProperty("access_key")]
        public string AccessKey { get; set; }
    }
}
