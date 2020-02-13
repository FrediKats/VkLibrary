using Newtonsoft.Json;

namespace VkApi.Wrapper.Types.Messages
{
    public class MessagesConversationWithMessage
    {
        [JsonProperty("conversation")]
        public MessagesConversation Conversation { get; set; }
        [JsonProperty("last_message")]
        public MessagesMessage LastMessage { get; set; }
    }
}