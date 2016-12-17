using System;
using Newtonsoft.Json;

namespace VkLib.Types.Newsfeed 
{
    public class List
    {
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
        /// Information whether reposts hiding is enabled
        /// </summary>
        [JsonProperty("no_reposts")]
        public BoolInt NoReposts { get; set; }

        /// <summary>
        /// List title
        /// </summary>
        [JsonProperty("title")]
        public string Title { get; set; }

    }
}
