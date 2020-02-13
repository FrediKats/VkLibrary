using Newtonsoft.Json;
using VkApi.Wrapper.Types.Friends;

namespace VkApi.Wrapper.Responses.Friends
{
    public class FriendsGetFieldsResponse
    {
        ///<summary>
        /// Total friends number
        ///</summary>
        [JsonProperty("count")]
        public int Count { get; set; }
        [JsonProperty("items")]
        public FriendsUserXtrLists[] Items { get; set; }
    }
}