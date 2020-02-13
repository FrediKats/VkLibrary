using Newtonsoft.Json;

namespace VkApi.Wrapper.Types.Callback
{
    public class CallbackGroupChangeSettings
    {
        [JsonProperty("user_id")]
        public int UserId { get; set; }
        [JsonProperty("self")]
        public int Self { get; set; }
    }
}