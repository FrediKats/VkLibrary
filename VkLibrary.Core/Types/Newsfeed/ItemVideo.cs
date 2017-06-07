using Newtonsoft.Json;

namespace VkLibrary.Core.Types.Newsfeed
{
    /// <summary>
    /// API ItemVideo object.
    /// </summary>
    public class ItemVideo
    {
        /// <summary>
        /// Property
        /// </summary>
        [JsonProperty("video")]
        public ItemVideoVideo Video { get; set; }
    }
}