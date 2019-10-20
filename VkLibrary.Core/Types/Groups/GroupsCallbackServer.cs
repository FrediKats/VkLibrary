using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace VkLibrary.Core.Objects
{
    public class GroupsCallbackServer
    {
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("title")]
        public String Title { get; set; }
        [JsonProperty("creator_id")]
        public int CreatorId { get; set; }
        [JsonProperty("url")]
        public String Url { get; set; }
        [JsonProperty("secret_key")]
        public String SecretKey { get; set; }
        [JsonProperty("status")]
        public String Status { get; set; }
    }
}