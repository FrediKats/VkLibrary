using Newtonsoft.Json;
using VkApi.Wrapper.Types.Newsfeed;

namespace VkApi.Wrapper.Responses.Newsfeed
{
    public class NewsfeedGetListsExtendedResponse
    {
        ///<summary>
        /// Total number
        ///</summary>
        [JsonProperty("count")]
        public int Count { get; set; }
        [JsonProperty("items")]
        public NewsfeedListFull[] Items { get; set; }
    }
}