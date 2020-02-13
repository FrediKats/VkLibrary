using Newtonsoft.Json;

namespace VkApi.Wrapper.Types.Messages
{
    public class MessagesConversationPeer
    {
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("local_id")]
        public int LocalId { get; set; }
        [JsonProperty("type")]
        public MessagesConversationPeerType Type { get; set; }
    }
}