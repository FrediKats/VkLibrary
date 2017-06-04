using Newtonsoft.Json;

namespace VkLibrary.Core.Types.Base
{
    public class LinkButtonAction
    {
        /// <summary>
        /// Action URL
        /// </summary>
        [JsonProperty("url")]
        public string Url { get; set; }

        /// <summary>
        /// Property
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }
    }
}