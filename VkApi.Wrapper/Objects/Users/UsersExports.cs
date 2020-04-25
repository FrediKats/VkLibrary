using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace VkApi.Wrapper.Objects
{
    public class UsersExports
    {
        [JsonProperty("facebook")]
        public int Facebook { get; set; }
        [JsonProperty("livejournal")]
        public int Livejournal { get; set; }
        [JsonProperty("twitter")]
        public int Twitter { get; set; }
    }
}