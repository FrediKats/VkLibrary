using Newtonsoft.Json;
using VkApi.Wrapper.Types.Friends;

namespace VkApi.Wrapper.Responses.Friends
{
    public class FriendsGetRequestsExtendedResponse
    {
        ///<summary>
        /// Total requests number
        ///</summary>
        [JsonProperty("count")]
        public int Count { get; set; }
        [JsonProperty("items")]
        public FriendsRequestsXtrMessage[] Items { get; set; }
    }
}