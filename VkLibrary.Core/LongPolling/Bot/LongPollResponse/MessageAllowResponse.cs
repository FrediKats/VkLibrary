using Newtonsoft.Json;

namespace VkApi.Wrapper.LongPolling.Bot.LongPollResponse
{
    public class MessageAllowResponse
    {
        [JsonProperty("user_id")]
        public int UserId { get; set; }

        [JsonProperty("key")]
        public string Key { get; set; }
    }
}