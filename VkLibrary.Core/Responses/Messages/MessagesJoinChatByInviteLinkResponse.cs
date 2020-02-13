using Newtonsoft.Json;

namespace VkApi.Wrapper.Responses.Messages
{
    public class MessagesJoinChatByInviteLinkResponse
    {
        [JsonProperty("chat_id")]
        public int ChatId { get; set; }
    }
}