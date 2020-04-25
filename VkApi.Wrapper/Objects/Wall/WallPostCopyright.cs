using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace VkApi.Wrapper.Objects
{
    public class WallPostCopyright
    {
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("link")]
        public String Link { get; set; }
        [JsonProperty("name")]
        public String Name { get; set; }
        [JsonProperty("type")]
        public String Type { get; set; }
    }
}