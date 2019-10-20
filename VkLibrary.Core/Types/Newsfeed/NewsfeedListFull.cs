using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace VkLibrary.Core.Objects
{
    public class NewsfeedListFull
    {
        ///<summary>
        /// Information whether reposts hiding is enabled
        ///</summary>
        [JsonProperty("no_reposts")]
        public int NoReposts { get; set; }
        [JsonProperty("source_ids")]
        public int[] SourceIds { get; set; }
    }
}