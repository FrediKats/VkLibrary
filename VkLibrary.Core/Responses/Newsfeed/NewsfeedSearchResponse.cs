using System;
using Newtonsoft.Json;
using VkApi.Wrapper.Types.Wall;

namespace VkApi.Wrapper.Responses.Newsfeed
{
    public class NewsfeedSearchResponse
    {
        [JsonProperty("items")]
        public WallWallpostFull[] Items { get; set; }
        [JsonProperty("suggested_queries")]
        public String[] SuggestedQueries { get; set; }
    }
}