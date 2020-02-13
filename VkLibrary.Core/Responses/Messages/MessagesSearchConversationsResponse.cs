using Newtonsoft.Json;
using VkApi.Wrapper.Types.Groups;
using VkApi.Wrapper.Types.Messages;
using VkApi.Wrapper.Types.Users;

namespace VkApi.Wrapper.Responses.Messages
{
    public class MessagesSearchConversationsResponse
    {
        ///<summary>
        /// Total results number
        ///</summary>
        [JsonProperty("count")]
        public int Count { get; set; }
        [JsonProperty("items")]
        public MessagesConversation[] Items { get; set; }
        [JsonProperty("profiles")]
        public UsersUserFull[] Profiles { get; set; }
        [JsonProperty("groups")]
        public GroupsGroupFull[] Groups { get; set; }
    }
}