using Newtonsoft.Json;

namespace VkApi.Wrapper.LongPolling.Bot.Responses
{
    /// <summary>
    /// BotLongPoll response for <see cref="BotLongPollMessageCodes"/>
    /// </summary>
    public class MessageDenyResponse
    {
        /// <summary>
        /// User ID
        /// </summary>
        [JsonProperty("user_id")]
        public int UserId { get; set; }
    }
}