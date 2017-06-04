using System.Collections.Generic;
using Newtonsoft.Json;

namespace VkLibrary.Core.Types.Account
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
        public IEnumerable<PushConversationsItem> Items { get; set; }
    }
}