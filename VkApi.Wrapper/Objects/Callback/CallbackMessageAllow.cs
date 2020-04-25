using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace VkApi.Wrapper.Objects
{
    public class CallbackMessageAllow
    {
        [JsonProperty("user_id")]
        public int UserId { get; set; }
        [JsonProperty("key")]
        public String Key { get; set; }
    }
}