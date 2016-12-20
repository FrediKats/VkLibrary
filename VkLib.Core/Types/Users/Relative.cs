using System;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace VkLib.Types.Users 
{
    public class Relative
    {
        /// <summary>
        /// Relative type
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }

        /// <summary>
        /// Relative ID
        /// </summary>
        [JsonProperty("id")]
        public int? Id { get; set; }

    }
}
