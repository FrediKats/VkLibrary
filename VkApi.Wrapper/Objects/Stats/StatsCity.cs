using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace VkApi.Wrapper.Objects
{
    public class StatsCity
    {
        ///<summary>
        /// Visitors number
        ///</summary>
        [JsonProperty("count")]
        public int Count { get; set; }

        ///<summary>
        /// City name
        ///</summary>
        [JsonProperty("name")]
        public String Name { get; set; }

        ///<summary>
        /// City ID
        ///</summary>
        [JsonProperty("value")]
        public int Value { get; set; }
    }
}