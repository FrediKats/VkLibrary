using System.Collections.Generic;
using Newtonsoft.Json;

namespace VkLibrary.Core.Types.Messages
{
    public class LongpollMessages
    {
        /// <summary>
        /// Total number
        /// </summary>
        [JsonProperty("count")]
        public int? Count { get; set; }

        /// <summary>
        /// Property
        /// </summary>
        [JsonProperty("items")]
        public IEnumerable<Message> Items { get; set; }
    }
}