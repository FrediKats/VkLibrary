using Newtonsoft.Json;
using VkApi.Wrapper.Types.Groups;
using VkApi.Wrapper.Types.Messages;
using VkApi.Wrapper.Types.Users;

namespace VkApi.Wrapper.Responses.Messages
{
    public class MessagesGetConversationsResponse
    {
        ///<summary>
        /// Total number
        ///</summary>
        [JsonProperty("count")]
        public int Count { get; set; }

        ///<summary>
        /// Unread dialogs number
        ///</summary>
        [JsonProperty("unread_count")]
        public int UnreadCount { get; set; }
        [JsonProperty("items")]
        public MessagesConversationWithMessage[] Items { get; set; }
        [JsonProperty("profiles")]
        public UsersUserFull[] Profiles { get; set; }
        [JsonProperty("groups")]
        public GroupsGroupFull[] Groups { get; set; }
    }
}