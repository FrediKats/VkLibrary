using System;
using Newtonsoft.Json;

namespace VkLib.Types.Base 
{
    public class Geo
    {
        /// <summary>
        /// Place type
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }

        /// <summary>
        /// Property
        /// </summary>
        [JsonProperty("place")]
        public Place Place { get; set; }

        /// <summary>
        /// String with coordinates
        /// </summary>
        [JsonProperty("coordinates")]
        public string Coordinates { get; set; }

        /// <summary>
        /// Information whether a map is showed
        /// </summary>
        [JsonProperty("showmap")]
        public int? Showmap { get; set; }

    }
}
