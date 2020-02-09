using Newtonsoft.Json;

namespace VkApi.Wrapper.LongPolling.Bot.LongPollResponse
{
    public class MessageDenyResponse
    {
        [JsonProperty("user_id")]
        public int UserId { get; set; }
    }
}