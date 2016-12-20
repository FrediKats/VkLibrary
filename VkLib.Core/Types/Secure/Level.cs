using System;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace VkLib.Types.Secure 
{
    public class Level
    {
        /// <summary>
        /// Level
        /// </summary>
        [JsonProperty("level")]
        public int? Level_ { get; set; }

        /// <summary>
        /// User ID
        /// </summary>
        [JsonProperty("uid")]
        public int? Uid { get; set; }

    }
}
