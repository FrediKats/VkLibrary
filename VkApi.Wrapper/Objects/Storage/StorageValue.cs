using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace VkApi.Wrapper.Objects
{
    public class StorageValue
    {
        [JsonProperty("key")]
        public String Key { get; set; }
        [JsonProperty("value")]
        public String Value { get; set; }
    }
}