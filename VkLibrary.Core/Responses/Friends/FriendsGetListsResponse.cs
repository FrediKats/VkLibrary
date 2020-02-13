using Newtonsoft.Json;
using VkApi.Wrapper.Types.Friends;

namespace VkApi.Wrapper.Responses.Friends
{
    public class FriendsGetListsResponse
    {
        ///<summary>
        /// Total communities number
        ///</summary>
        [JsonProperty("count")]
        public int Count { get; set; }
        [JsonProperty("items")]
        public FriendsFriendsList[] Items { get; set; }
    }
}