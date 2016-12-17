using System;
using Newtonsoft.Json;

namespace VkLib.Types.Users 
{
    public class UsersArray
    {
        /// <summary>
        /// Property
        /// </summary>
        [JsonProperty("items")]
        public IEnumerable<int?> Items { get; set; }

        /// <summary>
        /// Users number
        /// </summary>
        [JsonProperty("count")]
        public int? Count { get; set; }

    }
}
