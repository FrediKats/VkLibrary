using Newtonsoft.Json;
using VkApi.Wrapper.Types.Board;

namespace VkApi.Wrapper.LongPolling.Bot.Responses
{
    public class BoardTopicResponse : BoardTopicComment
    {
        [JsonProperty("topic_id")]
        public int TopicId { get; set; }

        [JsonProperty("topic_owner_id")]
        public int TopicOwnerId { get; set; }
    }
}