using System;
using Newtonsoft.Json;

namespace VkLib.Types.Secure 
{
    public class Level
    {
        /// <summary>
        /// Level
        /// </summary>
        [JsonProperty("level")]
        public int? Level { get; set; }

        /// <summary>
        /// User ID
        /// </summary>
        [JsonProperty("uid")]
        public int? Uid { get; set; }

    }
}
