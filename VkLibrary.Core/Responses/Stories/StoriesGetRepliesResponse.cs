using Newtonsoft.Json;
using VkApi.Wrapper.Types.Stories;

namespace VkApi.Wrapper.Responses.Stories
{
    public class StoriesGetRepliesResponse
    {
        ///<summary>
        /// Stories count
        ///</summary>
        [JsonProperty("count")]
        public int Count { get; set; }
        [JsonProperty("items")]
        public StoriesStory[][] Items { get; set; }
    }
}