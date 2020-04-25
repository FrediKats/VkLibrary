using Newtonsoft.Json;
using VkApi.Wrapper.Objects;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace VkApi.Wrapper.Responses
{
    public class NewsfeedGetBannedResponse
    {
        [JsonProperty("groups")]
        public int[] Groups { get; set; }
        [JsonProperty("members")]
        public int[] Members { get; set; }
    }
}