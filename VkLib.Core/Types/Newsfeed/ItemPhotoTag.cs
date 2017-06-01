using Newtonsoft.Json;

namespace VkLib.Types.Newsfeed
{
    public class ItemPhotoTag
    {
        /// <summary>
        ///     Property
        /// </summary>
        [JsonProperty("photo_tags")]
        public ItemPhotoTagPhotoTags PhotoTags { get; set; }

        /// <summary>
        ///     Post ID
        /// </summary>
        [JsonProperty("post_id")]
        public int? PostId { get; set; }
    }
}