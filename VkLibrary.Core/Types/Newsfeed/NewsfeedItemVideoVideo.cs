using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace VkLibrary.Core.Objects
{
    public class NewsfeedItemVideoVideo
    {
        ///<summary>
        /// Tags number
        ///</summary>
        [JsonProperty("count")]
        public int Count { get; set; }
        [JsonProperty("items")]
        public VideoVideo[] Items { get; set; }
    }
}