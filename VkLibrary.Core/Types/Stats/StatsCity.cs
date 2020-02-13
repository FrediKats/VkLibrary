using System;
using Newtonsoft.Json;

namespace VkApi.Wrapper.Types.Stats
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