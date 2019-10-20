using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace VkLibrary.Core.Objects
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