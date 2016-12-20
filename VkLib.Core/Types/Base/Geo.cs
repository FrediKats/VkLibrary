using System;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace VkLib.Types.Base 
{
    public class Geo
    {
        /// <summary>
        /// Information whether a map is showed
        /// </summary>
        [JsonProperty("showmap")]
        public int? Showmap_ { get; set; }

        /// <summary>
        /// Place type
        /// </summary>
        [JsonProperty("type")]
        public string Type_ { get; set; }

        /// <summary>
        /// Property
        /// </summary>
        [JsonProperty("place")]
        public VkLib.Types.Base.Place Place_ { get; set; }

        /// <summary>
        /// String with coordinates
        /// </summary>
        [JsonProperty("coordinates")]
        public string Coordinates_ { get; set; }

    }
}
