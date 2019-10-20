using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace VkLibrary.Core.Objects
{
    public class StoriesStoryStatsStat
    {
        ///<summary>
        /// Stat value
        ///</summary>
        [JsonProperty("count")]
        public int Count { get; set; }
        [JsonProperty("state")]
        public StoriesStoryStatsState State { get; set; }
    }
}