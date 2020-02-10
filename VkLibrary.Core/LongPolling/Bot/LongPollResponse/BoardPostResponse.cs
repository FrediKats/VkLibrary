using Newtonsoft.Json;
using VkLibrary.Core.Objects;

namespace VkApi.Wrapper.LongPolling.Bot.LongPollResponse
{
    public class BoardTopicResponse : BoardTopicComment
    {
        [JsonProperty("topic_id")]
        public int TopicId { get; set; }

        [JsonProperty("topic_owner_id")]
        public int TopicOwnerId { get; set; }
    }
}