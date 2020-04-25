using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace VkApi.Wrapper.Objects
{
    public class CallbackMessageBase
    {
        [JsonProperty("type")]
        public CallbackMessageType Type { get; set; }
        [JsonProperty("object")]
        public Object Object { get; set; }
        [JsonProperty("group_id")]
        public int GroupId { get; set; }
    }
}