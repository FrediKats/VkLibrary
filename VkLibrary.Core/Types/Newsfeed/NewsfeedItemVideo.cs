using Newtonsoft.Json;

namespace VkApi.Wrapper.Types.Newsfeed
{
    public class NewsfeedItemVideo
    {
        [JsonProperty("video")]
        public NewsfeedItemVideoVideo Video { get; set; }
    }
}