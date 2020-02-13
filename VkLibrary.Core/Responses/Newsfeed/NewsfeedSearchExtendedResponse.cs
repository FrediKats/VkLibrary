using System;
using Newtonsoft.Json;
using VkApi.Wrapper.Types.Groups;
using VkApi.Wrapper.Types.Users;
using VkApi.Wrapper.Types.Wall;

namespace VkApi.Wrapper.Responses.Newsfeed
{
    public class NewsfeedSearchExtendedResponse
    {
        [JsonProperty("items")]
        public WallWallpostFull[] Items { get; set; }
        [JsonProperty("profiles")]
        public UsersUserFull[] Profiles { get; set; }
        [JsonProperty("groups")]
        public GroupsGroupFull[] Groups { get; set; }

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
        [JsonProperty("next_from")]
        public String NextFrom { get; set; }
    }
}