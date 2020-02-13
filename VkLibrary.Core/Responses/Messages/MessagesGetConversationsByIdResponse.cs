using Newtonsoft.Json;
using VkApi.Wrapper.Types.Messages;

namespace VkApi.Wrapper.Responses.Messages
{
    public class MessagesGetConversationsByIdResponse
    {
        ///<summary>
        /// Total number
        ///</summary>
        [JsonProperty("count")]
        public int Count { get; set; }
        [JsonProperty("items")]
        public MessagesConversation[] Items { get; set; }
    }
}