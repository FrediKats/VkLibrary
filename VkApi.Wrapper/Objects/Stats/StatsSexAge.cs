using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace VkApi.Wrapper.Objects
{
    public class StatsSexAge
    {
        ///<summary>
        /// Visitors number
        ///</summary>
        [JsonProperty("count")]
        public int Count { get; set; }

        ///<summary>
        /// Sex/age value
        ///</summary>
        [JsonProperty("value")]
        public String Value { get; set; }
        [JsonProperty("reach")]
        public int Reach { get; set; }
        [JsonProperty("reach_subscribers")]
        public int ReachSubscribers { get; set; }
        [JsonProperty("count_subscribers")]
        public int CountSubscribers { get; set; }
    }
}