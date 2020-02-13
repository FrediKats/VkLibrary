using Newtonsoft.Json;
using VkApi.Wrapper.Types.Messages;

namespace VkApi.Wrapper.Responses.Messages
{
    public class MessagesSetChatPhotoResponse
    {
        ///<summary>
        /// Service message ID
        ///</summary>
        [JsonProperty("message_id")]
        public int MessageId { get; set; }
        [JsonProperty("chat")]
        public MessagesChat Chat { get; set; }
    }
}