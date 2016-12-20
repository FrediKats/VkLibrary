using System;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace VkLib.Types.Secure 
{
    public class Level
    {
        /// <summary>
        /// User ID
        /// </summary>
        [JsonProperty("uid")]
        public int? Uid_ { get; set; }

        /// <summary>
        /// Level
        /// </summary>
        [JsonProperty("level")]
        public int? Level_ { get; set; }

    }
}
