using System.Collections.Generic;
using Newtonsoft.Json;
using VkLib.Types.Groups;
using VkLib.Types.Users;

namespace VkLib.Responses.Newsfeed
{
    public class GetBannedExtendedResponse
    {
        /// <summary>
        ///     None
        /// </summary>
        [JsonProperty("groups")]
        public IEnumerable<UserFull> Groups { get; set; }

        /// <summary>
        ///     None
        /// </summary>
        [JsonProperty("members")]
        public IEnumerable<GroupFull> Members { get; set; }
    }
}