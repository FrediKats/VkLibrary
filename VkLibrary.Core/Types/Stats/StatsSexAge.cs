using System;
using Newtonsoft.Json;

namespace VkApi.Wrapper.Types.Stats
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
    }
}