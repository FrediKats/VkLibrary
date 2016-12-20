using System;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace VkLib.Types.Account 
{
    public class PushConversations
    {
        /// <summary>
        /// Items count
        /// </summary>
        [JsonProperty("count")]
        public int? Count { get; set; }

        /// <summary>
        /// Property
        /// </summary>
        [JsonProperty("items")]
        public IEnumerable<VkLib.Types.Account.PushConversationsItem> Items { get; set; }

    }
}
