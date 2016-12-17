using System;
using Newtonsoft.Json;

namespace VkLib.Types.Groups 
{
    public class GroupsArray
    {
        /// <summary>
        /// Property
        /// </summary>
        [JsonProperty("items")]
        public IEnumerable<int?> Items { get; set; }

        /// <summary>
        /// Communities number
        /// </summary>
        [JsonProperty("count")]
        public int? Count { get; set; }

    }
}
