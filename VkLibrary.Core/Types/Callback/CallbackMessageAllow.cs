using System;
using Newtonsoft.Json;

namespace VkApi.Wrapper.Types.Callback
{
    public class CallbackMessageAllow
    {
        [JsonProperty("user_id")]
        public int UserId { get; set; }
        [JsonProperty("key")]
        public String Key { get; set; }
    }
}