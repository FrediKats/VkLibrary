using Newtonsoft.Json;
using VkApi.Wrapper.Types.Apps;
using VkApi.Wrapper.Types.Users;

namespace VkApi.Wrapper.Responses.Apps
{
    public class AppsGetLeaderboardExtendedResponse
    {
        ///<summary>
        /// Total number
        ///</summary>
        [JsonProperty("count")]
        public int Count { get; set; }
        [JsonProperty("items")]
        public AppsLeaderboard[] Items { get; set; }
        [JsonProperty("profiles")]
        public UsersUserMin[] Profiles { get; set; }
    }
}