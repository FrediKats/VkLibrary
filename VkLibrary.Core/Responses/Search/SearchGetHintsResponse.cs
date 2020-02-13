using System;
using Newtonsoft.Json;
using VkApi.Wrapper.Types.Search;

namespace VkApi.Wrapper.Responses.Search
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