using Newtonsoft.Json;
using VkApi.Wrapper.Types.Video;

namespace VkApi.Wrapper.Responses.Video
{
    public class VideoGetResponse
    {
        ///<summary>
        /// Total number
        ///</summary>
        [JsonProperty("count")]
        public int Count { get; set; }
        [JsonProperty("items")]
        public VideoVideo[] Items { get; set; }
    }
}