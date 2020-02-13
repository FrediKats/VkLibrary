using Newtonsoft.Json;
using VkApi.Wrapper.Types.Groups;
using VkApi.Wrapper.Types.Users;

namespace VkApi.Wrapper.Responses.Account
{
    public class AccountGetBannedResponse
    {
        ///<summary>
        /// Total number
        ///</summary>
        [JsonProperty("count")]
        public int Count { get; set; }
        [JsonProperty("items")]
        public int[] Items { get; set; }
        [JsonProperty("profiles")]
        public UsersUserMin[] Profiles { get; set; }
        [JsonProperty("groups")]
        public GroupsGroup[] Groups { get; set; }
    }
}