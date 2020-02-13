using Newtonsoft.Json;

namespace VkApi.Wrapper.Responses.Stories
{
    public class StoriesGetViewersResponse
    {
        ///<summary>
        /// Viewers count
        ///</summary>
        [JsonProperty("count")]
        public int Count { get; set; }
        [JsonProperty("items")]
        public int[] Items { get; set; }
    }
}