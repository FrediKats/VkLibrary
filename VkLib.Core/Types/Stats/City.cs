using System;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace VkLib.Types.Stats 
{
    public class City
    {
        /// <summary>
        /// City name
        /// </summary>
        [JsonProperty("name")]
        public string Name_ { get; set; }

        /// <summary>
        /// Visitors number
        /// </summary>
        [JsonProperty("visitors")]
        public int? Visitors_ { get; set; }

        /// <summary>
        /// City ID
        /// </summary>
        [JsonProperty("value")]
        public int? Value_ { get; set; }

    }
}
