using System;
using Newtonsoft.Json;

namespace VkApi.Wrapper.Types.Storage
{
    public class StorageValue
    {
        [JsonProperty("key")]
        public String Key { get; set; }
        [JsonProperty("value")]
        public String Value { get; set; }
    }
}