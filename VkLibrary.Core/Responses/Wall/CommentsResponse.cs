using System.Collections.Generic;
using Newtonsoft.Json;
using VkLibrary.Core.Types.Groups;
using VkLibrary.Core.Types.Users;
using VkLibrary.Core.Types.Wall;

namespace VkLibrary.Core.Responses.Wall
{
    /// <summary>
    /// API CommentsResponse.
    /// </summary>
    public class CommentsResponse
    {
        /// <summary>
        /// Comments list.
        /// </summary>
        [JsonProperty("items")]
        public List<WallComment> Items { get; set; }

        /// <summary>
        /// Profiles referenced in comments list.
        /// </summary>
        [JsonProperty("profiles")]
        public List<UserFull> Profiles { get; set; }

        /// <summary>
        /// Groups referenced in comments list.
        /// </summary>
        [JsonProperty("groups")]
        public List<GroupFull> Groups { get; set; }

        /// <summary>
        /// New offset.
        /// </summary>
        [JsonProperty("new_offset")]
        public string NewOffset { get; set; }

        /// <summary>
        /// Value used to view next comments page.
        /// </summary>
        [JsonProperty("next_from")]
        public string NextFrom { get; set; }

        /// <summary>
        /// Total comments count.
        /// </summary>
        [JsonProperty("count")]
        public int? Count { get; set; }
    }
}