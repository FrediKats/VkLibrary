using Newtonsoft.Json;

namespace VkLib.Types.Newsfeed
{
    public class ItemVideo
    {
        /// <summary>
        ///     Property
        /// </summary>
        [JsonProperty("video")]
        public ItemVideoVideo Video { get; set; }
    }
}