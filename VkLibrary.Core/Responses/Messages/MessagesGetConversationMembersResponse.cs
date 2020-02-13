using Newtonsoft.Json;
using VkApi.Wrapper.Types.Groups;
using VkApi.Wrapper.Types.Messages;
using VkApi.Wrapper.Types.Users;

namespace VkApi.Wrapper.Responses.Messages
{
    public class MessagesGetConversationMembersResponse
    {
        ///<summary>
        /// Chat members count
        ///</summary>
        [JsonProperty("count")]
        public int Count { get; set; }
        [JsonProperty("items")]
        public MessagesConversationMember[] Items { get; set; }
        [JsonProperty("chat_restrictions")]
        public MessagesChatRestrictions ChatRestrictions { get; set; }
        [JsonProperty("profiles")]
        public UsersUserFull[] Profiles { get; set; }
        [JsonProperty("groups")]
        public GroupsGroupFull[] Groups { get; set; }
    }
}