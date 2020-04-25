using Newtonsoft.Json;
using VkApi.Wrapper.Objects;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace VkApi.Wrapper.Responses
{
    public class NewsfeedSearchResponse
    {
        [JsonProperty("items")]
        public WallWallpostFull[] Items { get; set; }
        [JsonProperty("suggested_queries")]
        public String[] SuggestedQueries { get; set; }
        [JsonProperty("next_from")]
        public String NextFrom { get; set; }

        ///<summary>
        /// Filtered number
        ///</summary>
        [JsonProperty("count")]
        public int Count { get; set; }

        ///<summary>
        /// Total number
        ///</summary>
        [JsonProperty("total_count")]
        public int TotalCount { get; set; }
    }
}