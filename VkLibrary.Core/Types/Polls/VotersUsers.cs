using System.Collections.Generic;
using Newtonsoft.Json;

namespace VkLibrary.Core.Types.Polls
{
    /// <summary>
    /// API VotersUsers object.
    /// </summary>
    public class VotersUsers
    {
        /// <summary>
        /// Votes number
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