using Newtonsoft.Json;

namespace VkApi.Wrapper.Types.Callback
{
    public class CallbackBoardPostDelete
    {
        [JsonProperty("topic_owner_id")]
        public int TopicOwnerId { get; set; }
        [JsonProperty("topic_id")]
        public int TopicId { get; set; }
        [JsonProperty("id")]
        public int Id { get; set; }
    }
}