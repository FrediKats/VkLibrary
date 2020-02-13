using Newtonsoft.Json;
using VkApi.Wrapper.Types.Apps;

namespace VkApi.Wrapper.Responses.Apps
{
    public class AppsGetLeaderboardResponse
    {
        ///<summary>
        /// Total number
        ///</summary>
        [JsonProperty("count")]
        public int Count { get; set; }
        [JsonProperty("items")]
        public AppsLeaderboard[] Items { get; set; }
    }
}