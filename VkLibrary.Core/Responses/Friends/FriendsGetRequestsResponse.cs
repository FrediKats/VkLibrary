using Newtonsoft.Json;

namespace VkApi.Wrapper.Responses.Friends
{
    public class FriendsGetRequestsResponse
    {
        ///<summary>
        /// Total requests number
        ///</summary>
        [JsonProperty("count")]
        public int Count { get; set; }
        [JsonProperty("items")]
        public int[] Items { get; set; }

        ///<summary>
        /// Total unread requests number
        ///</summary>
        [JsonProperty("count_unread")]
        public int CountUnread { get; set; }
    }
}