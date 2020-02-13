using Newtonsoft.Json;

namespace VkApi.Wrapper.Types.Callback
{
    public class CallbackGroupLeave
    {
        [JsonProperty("user_id")]
        public int UserId { get; set; }
        [JsonProperty("self")]
        public int Self { get; set; }
    }
}