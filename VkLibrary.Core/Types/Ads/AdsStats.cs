using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace VkLibrary.Core.Objects
{
    public class AdsStats
    {
        ///<summary>
        /// Object ID
        ///</summary>
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("stats")]
        public AdsStatsFormat Stats { get; set; }
        [JsonProperty("type")]
        public AdsObjectType Type { get; set; }
    }
}