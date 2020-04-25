using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace VkApi.Wrapper.Objects
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
        [JsonProperty("views_times")]
        public AdsStatsViewsTimes ViewsTimes { get; set; }
    }
}