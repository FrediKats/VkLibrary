using System.Collections.Generic;
using Newtonsoft.Json;

namespace VkLibrary.Core.Types.Newsfeed
{
    /// <summary>
    /// API List object.
    /// </summary>
    public class List
    {
        /// <summary>
        /// Information whether reposts hiding is enabled
        /// </summary>
        [JsonProperty("no_reposts")]
        public int? NoReposts { get; set; }

        /// <summary>
        /// Property
        /// </summary>
        [JsonProperty("source_ids")]
        public IEnumerable<int?> SourceIds { get; set; }

        /// <summary>
        /// List ID
        /// </summary>
        [JsonProperty("id")]
        public int? Id { get; set; }

        /// <summary>
        /// List title
        /// </summary>
        [JsonProperty("title")]
        public string Title { get; set; }
    }
}