using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace VkLibrary.Core.Objects
{
    public class NewsfeedItemStoriesBlock
    {
        [JsonProperty("block_type")]
        public String BlockType { get; set; }
        [JsonProperty("stories")]
        public StoriesStory[] Stories { get; set; }
        [JsonProperty("title")]
        public String Title { get; set; }
        [JsonProperty("track_code")]
        public String TrackCode { get; set; }
    }
}