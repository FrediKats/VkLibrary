using Newtonsoft.Json;
using VkApi.Wrapper.Types.Video;

namespace VkApi.Wrapper.Types.Newsfeed
{
    public class NewsfeedItemVideoVideo
    {
        ///<summary>
        /// Tags number
        ///</summary>
        [JsonProperty("count")]
        public int Count { get; set; }
        [JsonProperty("items")]
        public VideoVideo[] Items { get; set; }
    }
}