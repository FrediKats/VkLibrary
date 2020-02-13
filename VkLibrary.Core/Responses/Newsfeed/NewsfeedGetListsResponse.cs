using Newtonsoft.Json;
using VkApi.Wrapper.Types.Newsfeed;

namespace VkApi.Wrapper.Responses.Newsfeed
{
    public class NewsfeedGetListsResponse
    {
        ///<summary>
        /// Total number
        ///</summary>
        [JsonProperty("count")]
        public int Count { get; set; }
        [JsonProperty("items")]
        public NewsfeedList[] Items { get; set; }
    }
}