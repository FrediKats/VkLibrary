using Newtonsoft.Json;
using VkApi.Wrapper.Types.Fave;

namespace VkApi.Wrapper.Responses.Fave
{
    public class FaveGetTagsResponse
    {
        [JsonProperty("count")]
        public int Count { get; set; }
        [JsonProperty("items")]
        public FaveTag[] Items { get; set; }
    }
}