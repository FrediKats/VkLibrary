using System;
using Newtonsoft.Json;
using VkApi.Wrapper.Types.Stories;

namespace VkApi.Wrapper.Types.Newsfeed
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