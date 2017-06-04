using Newtonsoft.Json;

namespace VkLibrary.Core.Types.Newsfeed
{
    public class ItemVideo
    {
        /// <summary>
        /// Property
        /// </summary>
        [JsonProperty("video")]
        public ItemVideoVideo Video { get; set; }
    }
}