using Newtonsoft.Json;
using VkApi.Wrapper.Types.Users;

namespace VkApi.Wrapper.Responses.Friends
{
    public class FriendsGetSuggestionsResponse
    {
        ///<summary>
        /// Total results number
        ///</summary>
        [JsonProperty("count")]
        public int Count { get; set; }
        [JsonProperty("items")]
        public UsersUserFull[] Items { get; set; }
    }
}