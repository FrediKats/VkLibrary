using Newtonsoft.Json;

namespace VkApi.Wrapper.Types.Video
{
    public class VideoVideoImage
    {
        [JsonProperty("with_padding")]
        public int WithPadding { get; set; }
    }
}