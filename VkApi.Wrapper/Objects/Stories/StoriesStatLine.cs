using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace VkApi.Wrapper.Objects
{
    public class StoriesStatLine
    {
        [JsonProperty("name")]
        public String Name { get; set; }
        [JsonProperty("counter")]
        public int Counter { get; set; }
        [JsonProperty("is_unavailable")]
        public Boolean IsUnavailable { get; set; }
    }
}