using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace VkLibrary.Core.Objects
{
    public class NewsfeedItemBase
    {
        [JsonProperty("type")]
        public NewsfeedNewsfeedItemType Type { get; set; }

        ///<summary>
        /// Item source ID
        ///</summary>
        [JsonProperty("source_id")]
        public int SourceId { get; set; }

        ///<summary>
        /// Date when item has been added in Unixtime
        ///</summary>
        [JsonProperty("date")]
        public int Date { get; set; }
    }
}