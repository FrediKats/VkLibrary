using System.Collections.Generic;
using Newtonsoft.Json;
using VkLibrary.Core.Types.Groups;
using VkLibrary.Core.Types.Users;

namespace VkLibrary.Core.Responses.Newsfeed
{
    public class GetBannedExtendedResponse
    {
        /// <summary>
        /// None
        /// </summary>
        [JsonProperty("groups")]
        public IEnumerable<UserFull> Groups { get; set; }

        /// <summary>
        /// None
        /// </summary>
        [JsonProperty("members")]
        public IEnumerable<GroupFull> Members { get; set; }
    }
}