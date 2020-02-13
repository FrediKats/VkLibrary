using Newtonsoft.Json;

namespace VkApi.Wrapper.Types.Newsfeed
{
    public class NewsfeedItemPhotoTag
    {
        [JsonProperty("photo_tags")]
        public NewsfeedItemPhotoTagPhotoTags PhotoTags { get; set; }

        ///<summary>
        /// Post ID
        ///</summary>
        [JsonProperty("post_id")]
        public int PostId { get; set; }
    }
}