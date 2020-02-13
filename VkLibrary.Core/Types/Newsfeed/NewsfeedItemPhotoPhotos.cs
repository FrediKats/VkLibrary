using Newtonsoft.Json;

namespace VkApi.Wrapper.Types.Newsfeed
{
    public class NewsfeedItemPhotoPhotos
    {
        ///<summary>
        /// Photos number
        ///</summary>
        [JsonProperty("count")]
        public int Count { get; set; }
        [JsonProperty("items")]
        public NewsfeedNewsfeedPhoto[] Items { get; set; }
    }
}