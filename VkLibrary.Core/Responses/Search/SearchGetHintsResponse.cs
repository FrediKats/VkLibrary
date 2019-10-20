using Newtonsoft.Json;
using VkLibrary.Core.Objects;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace VkLibrary.Core.Responses
{
    public class SearchGetHintsResponse
    {
        [JsonProperty("count")]
        public int Count { get; set; }
        [JsonProperty("items")]
        public SearchHint[] Items { get; set; }
        [JsonProperty("suggested_queries")]
        public String[] SuggestedQueries { get; set; }
    }
}