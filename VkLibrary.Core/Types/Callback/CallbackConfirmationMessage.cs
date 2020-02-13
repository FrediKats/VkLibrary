using System;
using Newtonsoft.Json;

namespace VkApi.Wrapper.Types.Callback
{
    public class CallbackConfirmationMessage
    {
        [JsonProperty("type")]
        public CallbackMessageType Type { get; set; }
        [JsonProperty("group_id")]
        public int GroupId { get; set; }
        [JsonProperty("secret")]
        public String Secret { get; set; }
    }
}