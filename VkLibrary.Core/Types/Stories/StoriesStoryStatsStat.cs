using Newtonsoft.Json;

namespace VkApi.Wrapper.Types.Stories
{
    public class StoriesStoryStatsStat
    {
        ///<summary>
        /// Stat value
        ///</summary>
        [JsonProperty("count")]
        public int Count { get; set; }
        [JsonProperty("state")]
        public StoriesStoryStatsState State { get; set; }
    }
}