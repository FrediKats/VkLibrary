using System;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace VkLib.Types.Stats 
{
    public class Sex
    {
        /// <summary>
        /// Visitors number
        /// </summary>
        [JsonProperty("visitors")]
        public int? Visitors_ { get; set; }

        /// <summary>
        /// Sex
        /// </summary>
        [JsonProperty("value")]
        public string Value_ { get; set; }

    }
}
