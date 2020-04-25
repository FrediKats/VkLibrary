using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace VkApi.Wrapper.Objects
{
    public class PagesWikipageHistory
    {
        ///<summary>
        /// Version ID
        ///</summary>
        [JsonProperty("id")]
        public int Id { get; set; }

        ///<summary>
        /// Page size in bytes
        ///</summary>
        [JsonProperty("length")]
        public int Length { get; set; }

        ///<summary>
        /// Date when the page has been edited in Unixtime
        ///</summary>
        [JsonProperty("date")]
        public int Date { get; set; }

        ///<summary>
        /// Last editor ID
        ///</summary>
        [JsonProperty("editor_id")]
        public int EditorId { get; set; }

        ///<summary>
        /// Last editor name
        ///</summary>
        [JsonProperty("editor_name")]
        public String EditorName { get; set; }
    }
}