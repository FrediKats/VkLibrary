using Newtonsoft.Json;
using System.Collections.Generic;
using VkLib.Types.Groups;
using VkLib.Types.Newsfeed;
using VkLib.Types.Users;

namespace VkLib.Responses.Newsfeed
{
    public class NewsFeedResponse
    {
        [JsonProperty("items")]
        public IEnumerable<ItemWallpost> Items { get; set; }

        [JsonProperty("profiles")]
        public IEnumerable<UserFull> Profiles { get; set; }

        [JsonProperty("groups")]
        public IEnumerable<GroupFull> Groups { get; set; }

        [JsonProperty("new_offset")]
        public string NewOffset { get; set; }

        [JsonProperty("next_from")]
        public string NextFrom { get; set; }
    }
}
