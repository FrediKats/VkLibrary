using Newtonsoft.Json;

namespace VkApi.Wrapper.Types.Stories
{
    public class StoriesStoryStats
    {
        [JsonProperty("answer")]
        public StoriesStoryStatsStat Answer { get; set; }
        [JsonProperty("bans")]
        public StoriesStoryStatsStat Bans { get; set; }
        [JsonProperty("open_link")]
        public StoriesStoryStatsStat OpenLink { get; set; }
        [JsonProperty("replies")]
        public StoriesStoryStatsStat Replies { get; set; }
        [JsonProperty("shares")]
        public StoriesStoryStatsStat Shares { get; set; }
        [JsonProperty("subscribers")]
        public StoriesStoryStatsStat Subscribers { get; set; }
        [JsonProperty("views")]
        public StoriesStoryStatsStat Views { get; set; }
    }
}