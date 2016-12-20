using System;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace VkLib.Types.Friends 
{
    public class RequestsMutual
    {
        /// <summary>
        /// Total mutual friends number
        /// </summary>
        [JsonProperty("count")]
        public int? Count { get; set; }

        /// <summary>
        /// Property
        /// </summary>
        [JsonProperty("users")]
        public IEnumerable<int?> Users { get; set; }

    }
}
