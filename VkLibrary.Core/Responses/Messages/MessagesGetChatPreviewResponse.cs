using Newtonsoft.Json;
using VkApi.Wrapper.Types.Message;
using VkApi.Wrapper.Types.Users;

namespace VkApi.Wrapper.Responses.Messages
{
    public class MessagesGetChatPreviewResponse
    {
        [JsonProperty("preview")]
        public MessageChatPreview Preview { get; set; }
        [JsonProperty("profiles")]
        public UsersUserFull[] Profiles { get; set; }
    }
}