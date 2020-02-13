using Newtonsoft.Json;
using VkApi.Wrapper.Types.Friends;

namespace VkApi.Wrapper.Responses.Friends
{
    public class FriendsGetRequestsNeedMutualResponse
    {
        ///<summary>
        /// Total requests number
        ///</summary>
        [JsonProperty("count")]
        public int Count { get; set; }
        [JsonProperty("items")]
        public FriendsRequests[] Items { get; set; }
    }
}