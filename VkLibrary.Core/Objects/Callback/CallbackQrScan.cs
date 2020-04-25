using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace VkApi.Wrapper.Objects
{
    public class CallbackQrScan
    {
        [JsonProperty("user_id")]
        public int UserId { get; set; }
        [JsonProperty("data")]
        public String Data { get; set; }
        [JsonProperty("type")]
        public String Type { get; set; }
        [JsonProperty("subtype")]
        public String Subtype { get; set; }
        [JsonProperty("reread")]
        public Boolean Reread { get; set; }
    }
}