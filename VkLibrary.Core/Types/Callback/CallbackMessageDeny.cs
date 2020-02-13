using Newtonsoft.Json;

namespace VkApi.Wrapper.Types.Callback
{
    public class CallbackMessageDeny
    {
        [JsonProperty("user_id")]
        public int UserId { get; set; }
    }
}