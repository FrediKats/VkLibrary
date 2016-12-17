using System;
using Newtonsoft.Json;

namespace VkLib.Types.Pages 
{
    public class WikipageVersion
    {
        /// <summary>
        /// Page size in bytes
        /// </summary>
        [JsonProperty("length")]
        public int? Length { get; set; }

        /// <summary>
        /// Version ID
        /// </summary>
        [JsonProperty("id")]
        public int? Id { get; set; }

        /// <summary>
        /// Last editor name
        /// </summary>
        [JsonProperty("editor_name")]
        public string EditorName { get; set; }

        /// <summary>
        /// Last editor ID
        /// </summary>
        [JsonProperty("editor_id")]
        public int? EditorId { get; set; }

        /// <summary>
        /// Date when the page has been edited in Unixtime
        /// </summary>
        [JsonProperty("edited")]
        public int? Edited { get; set; }

    }
}
