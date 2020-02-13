using Newtonsoft.Json;

namespace VkApi.Wrapper.Responses.Newsfeed
{
    public class NewsfeedGetBannedResponse
    {
        [JsonProperty("groups")]
        public int[] Groups { get; set; }
        [JsonProperty("members")]
        public int[] Members { get; set; }
    }
}