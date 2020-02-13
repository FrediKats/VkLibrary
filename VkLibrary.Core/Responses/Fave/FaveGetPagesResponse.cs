using Newtonsoft.Json;
using VkApi.Wrapper.Types.Fave;

namespace VkApi.Wrapper.Responses.Fave
{
    public class FaveGetPagesResponse
    {
        [JsonProperty("count")]
        public int Count { get; set; }
        [JsonProperty("items")]
        public FavePage[] Items { get; set; }
    }
}