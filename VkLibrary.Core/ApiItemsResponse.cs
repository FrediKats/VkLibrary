using System.Collections.Generic;
using Newtonsoft.Json;

namespace VkLibrary.Core
{
    /// <summary>
    /// Extended collection response.
    /// </summary>
    /// <typeparam name="T">Object real type</typeparam>
    public class ApiItemsResponse<T>
    {
        /// <summary>
        /// Total items count.
        /// </summary>
        [JsonProperty("count")]
        public int Count { get; set; }

        /// <summary>
        /// Collection of items.
        /// </summary>
        [JsonProperty("items")]
        public List<T> Items { get; set; }

        /// <summary>
        /// Next-from indicator. Used in some methods like Newsfeed.Get.
        /// </summary>
        [JsonProperty("next_from")]
        public string NextFrom { get; set; }
    }
}
