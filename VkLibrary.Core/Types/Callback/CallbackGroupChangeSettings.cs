using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace VkLibrary.Core.Objects
{
    public class CallbackGroupChangeSettings
    {
        [JsonProperty("user_id")]
        public int UserId { get; set; }
        [JsonProperty("self")]
        public int Self { get; set; }
    }
}