using System;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace VkLib.Types.Users 
{
    public class Exports
    {
        /// <summary>
        /// Property
        /// </summary>
        [JsonProperty("twitter")]
        public int? Twitter { get; set; }

        /// <summary>
        /// Property
        /// </summary>
        [JsonProperty("facebook")]
        public int? Facebook { get; set; }

        /// <summary>
        /// Property
        /// </summary>
        [JsonProperty("livejournal")]
        public int? Livejournal { get; set; }

    }
}
