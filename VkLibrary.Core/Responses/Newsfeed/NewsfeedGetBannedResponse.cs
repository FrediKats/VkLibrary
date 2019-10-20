using Newtonsoft.Json;
using VkLibrary.Core.Objects;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace VkLibrary.Core.Responses
{
    public class NewsfeedGetBannedResponse
    {
        [JsonProperty("groups")]
        public int[] Groups { get; set; }
        [JsonProperty("members")]
        public int[] Members { get; set; }
    }
}