using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using VkLib.Types;

namespace VkLib.Responses.Newsfeed
{
    public class GetBannedExtendedResponse
    {
        /// <summary>
        /// None
        /// </summary>
        [JsonProperty("groups")]
        public IEnumerable<VkLib.Types.Users.UserFull> Groups { get; set; }

        /// <summary>
        /// None
        /// </summary>
        [JsonProperty("members")]
        public IEnumerable<VkLib.Types.Groups.GroupFull> Members { get; set; }

    }
}
