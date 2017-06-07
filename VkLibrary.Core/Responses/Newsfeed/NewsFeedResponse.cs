using System.Collections.Generic;
using Newtonsoft.Json;
using VkLibrary.Core.Types.Groups;
using VkLibrary.Core.Types.Newsfeed;
using VkLibrary.Core.Types.Users;

namespace VkLibrary.Core.Responses.Newsfeed
{
    /// <summary>
    /// API NewsFeedResponse.
    /// </summary>
    public class NewsFeedResponse
    {
        /// <summary>
        /// Posts list.
        /// </summary>
        [JsonProperty("items")]
        public List<ItemWallpost> Items { get; set; }

        /// <summary>
        /// Users whose ids were referenced in posts.
        /// </summary>
        [JsonProperty("profiles")]
        public List<UserFull> Profiles { get; set; }

        /// <summary>
        /// Groups whose ids were referenced in posts.
        /// </summary>
        [JsonProperty("groups")]
        public List<GroupFull> Groups { get; set; }

        /// <summary>
        /// New offset info.
        /// </summary>
        [JsonProperty("new_offset")]
        public string NewOffset { get; set; }

        /// <summary>
        /// Pass this into Newsfeed.Get to get next news page.
        /// </summary>
        [JsonProperty("next_from")]
        public string NextFrom { get; set; }

        /// <summary>
        /// Total items count (if API provides, otherwise null)
        /// </summary>
        [JsonProperty("count")]
        public int? Count { get; set; }
    }
}