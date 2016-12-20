using System;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace VkLib.Types.Stats 
{
    public class Country
    {
        /// <summary>
        /// Country code
        /// </summary>
        [JsonProperty("code")]
        public string Code_ { get; set; }

        /// <summary>
        /// Country name
        /// </summary>
        [JsonProperty("name")]
        public string Name_ { get; set; }

        /// <summary>
        /// Visitors number
        /// </summary>
        [JsonProperty("visitors")]
        public int? Visitors_ { get; set; }

        /// <summary>
        /// Country ID
        /// </summary>
        [JsonProperty("value")]
        public int? Value_ { get; set; }

    }
}
