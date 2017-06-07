using Newtonsoft.Json;

namespace VkLibrary.Core.Types.Newsfeed
{
    /// <summary>
    /// API ItemPhoto object.
    /// </summary>
    public class ItemPhoto
    {
        /// <summary>
        /// Post ID
        /// </summary>
        [JsonProperty("post_id")]
        public int? PostId { get; set; }

        /// <summary>
        /// Property
        /// </summary>
        [JsonProperty("photos")]
        public ItemPhotoPhotos Photos { get; set; }
    }
}