using Newtonsoft.Json;

namespace VkApi.Wrapper.Types.Newsfeed
{
    public class NewsfeedItemPhoto
    {
        [JsonProperty("photos")]
        public NewsfeedItemPhotoPhotos Photos { get; set; }

        ///<summary>
        /// Post ID
        ///</summary>
        [JsonProperty("post_id")]
        public int PostId { get; set; }
    }
}