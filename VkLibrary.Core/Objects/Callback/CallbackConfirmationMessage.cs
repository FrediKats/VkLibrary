using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace VkApi.Wrapper.Objects
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