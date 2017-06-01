using System.Collections.Generic;
using Newtonsoft.Json;
using VkLib.Types.Groups;
using VkLib.Types.Users;
using VkLib.Types.Wall;

namespace VkLib.Responses.Wall
{
    public class CommentsResponse
    {
        [JsonProperty("items")]
        public List<WallComment> Items { get; set; }

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