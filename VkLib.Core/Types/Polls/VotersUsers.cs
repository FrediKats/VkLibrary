using System.Collections.Generic;
using Newtonsoft.Json;

namespace VkLib.Types.Polls
{
    public class VotersUsers
    {
        /// <summary>
        ///     Votes number
        /// </summary>
        [JsonProperty("count")]
        public int? Count { get; set; }

        /// <summary>
        ///     Property
        /// </summary>
        [JsonProperty("items")]
        public IEnumerable<int?> Items { get; set; }
    }
}