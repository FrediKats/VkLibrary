using Newtonsoft.Json;

namespace VkApi.Wrapper.LongPolling.Bot.Responses
{
    public class MessageAllowResponse
    {
        [JsonProperty("user_id")]
        public int UserId { get; set; }

        [JsonProperty("key")]
        public string Key { get; set; }
    }
}