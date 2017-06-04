using System.Collections.Generic;
using Newtonsoft.Json;

namespace VkLibrary.Core.Responses.Newsfeed
{
    public class GetBannedResponse
    {
        /// <summary>
        /// None
        /// </summary>
        [JsonProperty("groups")]
        public IEnumerable<int?> Groups { get; set; }

        /// <summary>
        /// None
        /// </summary>
        [JsonProperty("members")]
        public IEnumerable<int?> Members { get; set; }
    }
}