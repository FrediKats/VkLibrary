using System.Collections.Generic;
using Newtonsoft.Json;

namespace VkLibrary.Core.Types.Groups
{
    public class GroupsArray
    {
        /// <summary>
        /// Communities number
        /// </summary>
        [JsonProperty("count")]
        public int? Count { get; set; }

        /// <summary>
        /// Property
        /// </summary>
        [JsonProperty("items")]
        public IEnumerable<int?> Items { get; set; }
    }
}