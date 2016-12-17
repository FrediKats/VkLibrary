using System;
using Newtonsoft.Json;

namespace VkLib.Types.Stats 
{
    public class Sex
    {
        /// <summary>
        /// Visitors number
        /// </summary>
        [JsonProperty("visitors")]
        public int? Visitors { get; set; }

        /// <summary>
        /// Sex
        /// </summary>
        [JsonProperty("value")]
        public string Value { get; set; }

    }
}
