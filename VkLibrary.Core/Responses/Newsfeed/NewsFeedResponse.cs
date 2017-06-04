using System.Collections.Generic;
using Newtonsoft.Json;
using VkLibrary.Core.Types.Groups;
using VkLibrary.Core.Types.Newsfeed;
using VkLibrary.Core.Types.Users;

namespace VkLibrary.Core.Responses.Newsfeed
{
    public class NewsFeedResponse
    {
        [JsonProperty("items")]
        public List<ItemWallpost> Items { get; set; }

        [JsonProperty("profiles")]
        public List<UserFull> Profiles { get; set; }

        [JsonProperty("groups")]
        public List<GroupFull> Groups { get; set; }

        [JsonProperty("new_offset")]
        public string NewOffset { get; set; }

        [JsonProperty("next_from")]
        public string NextFrom { get; set; }

        [JsonProperty("count")]
        public int? Count { get; set; }
    }
}