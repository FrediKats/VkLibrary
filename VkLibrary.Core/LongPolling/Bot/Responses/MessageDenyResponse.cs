using Newtonsoft.Json;

namespace VkApi.Wrapper.LongPolling.Bot.Responses
{
    public class MessageDenyResponse
    {
        [JsonProperty("user_id")]
        public int UserId { get; set; }
    }
}