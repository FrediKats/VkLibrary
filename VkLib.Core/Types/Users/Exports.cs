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
        [JsonProperty("livejournal")]
        public int? Livejournal_ { get; set; }

        /// <summary>
        /// Property
        /// </summary>
        [JsonProperty("facebook")]
        public int? Facebook_ { get; set; }

        /// <summary>
        /// Property
        /// </summary>
        [JsonProperty("twitter")]
        public int? Twitter_ { get; set; }

    }
}
