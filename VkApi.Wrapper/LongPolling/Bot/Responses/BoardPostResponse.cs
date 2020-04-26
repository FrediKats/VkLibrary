using Newtonsoft.Json;
using VkApi.Wrapper.Objects;

namespace VkApi.Wrapper.LongPolling.Bot.Responses
{
    /// <summary>
    /// BotLongPoll response for <see cref="BotLongPollMessageCodes"/>
    /// </summary>
    public class BoardTopicResponse : BoardTopicComment
    {
        /// <summary>
        /// Topic ID
        /// </summary>
        [JsonProperty("topic_id")]
        public int TopicId { get; set; }

        /// <summary>
        /// Topic owner ID
        /// </summary>
        [JsonProperty("topic_owner_id")]
        public int TopicOwnerId { get; set; }
    }
}