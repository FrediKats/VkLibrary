using System;
using Newtonsoft.Json;

namespace VkLib.Types.Stats 
{
    public class Country
    {
        /// <summary>
        /// Country name
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Visitors number
        /// </summary>
        [JsonProperty("visitors")]
        public int? Visitors { get; set; }

        /// <summary>
        /// Country code
        /// </summary>
        [JsonProperty("code")]
        public string Code { get; set; }

        /// <summary>
        /// Country ID
        /// </summary>
        [JsonProperty("value")]
        public int? Value { get; set; }

    }
}
