using Newtonsoft.Json;
using VkLibrary.Core.Objects;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace VkLibrary.Core.Responses
{
    public class NewsfeedSearchResponse
    {
        [JsonProperty("items")]
        public WallWallpostFull[] Items { get; set; }
        [JsonProperty("suggested_queries")]
        public String[] SuggestedQueries { get; set; }
    }
}