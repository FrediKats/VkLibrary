using System;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace VkLib.Types.Newsfeed 
{
    public class List
    {
        /// <summary>
        /// Information whether reposts hiding is enabled
        /// </summary>
        [JsonProperty("no_reposts")]
        public int? NoReposts { get; set; }

        /// <summary>
        /// List ID
        /// </summary>
        [JsonProperty("id")]
        public int? Id_ { get; set; }

        /// <summary>
        /// List title
        /// </summary>
        [JsonProperty("title")]
        public string Title_ { get; set; }

        /// <summary>
        /// Property
        /// </summary>
        [JsonProperty("source_ids")]
        public IEnumerable<int?> SourceIds { get; set; }

    }
}
