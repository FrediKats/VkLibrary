using VkApi.Wrapper.Methods;
using Newtonsoft.Json;

namespace VkApi.Wrapper.LongPolling.Bot.Responses
{
    /// <summary>
    /// BotLongPoll response for <see cref="BotLongPollMessageCodes"/>
    /// </summary>
    public class MessageAllowResponse
    {
        /// <summary>
        /// User ID
        /// </summary>
        [JsonProperty("user_id")]
        public int UserId { get; set; }

        /// <summary>
        /// Parameter from <see cref="Messages"/>.AllowMessagesFromGroup method
        /// </summary>
        [JsonProperty("key")]
        public string Key { get; set; }
    }
}