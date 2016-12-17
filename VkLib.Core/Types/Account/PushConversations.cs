using System;
using Newtonsoft.Json;

namespace VkLib.Types.Account 
{
    public class PushConversations
    {
        /// <summary>
        /// Property
        /// </summary>
        [JsonProperty("items")]
        public IEnumerable<PushConversationsItem> Items { get; set; }

        /// <summary>
        /// Items count
        /// </summary>
        [JsonProperty("count")]
        public int? Count { get; set; }

    }
}
