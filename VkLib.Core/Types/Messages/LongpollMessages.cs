using System;
using Newtonsoft.Json;

namespace VkLib.Types.Messages 
{
    public class LongpollMessages
    {
        /// <summary>
        /// Property
        /// </summary>
        [JsonProperty("items")]
        public IEnumerable<Message> Items { get; set; }

        /// <summary>
        /// Total number
        /// </summary>
        [JsonProperty("count")]
        public int? Count { get; set; }

    }
}
