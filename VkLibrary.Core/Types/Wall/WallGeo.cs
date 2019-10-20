using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace VkLibrary.Core.Objects
{
    public class WallGeo
    {
        ///<summary>
        /// Coordinates as string. <latitude> <longtitude>
        ///</summary>
        [JsonProperty("coordinates")]
        public String Coordinates { get; set; }
        [JsonProperty("place")]
        public BasePlace Place { get; set; }

        ///<summary>
        /// Information whether a map is showed
        ///</summary>
        [JsonProperty("showmap")]
        public int Showmap { get; set; }

        ///<summary>
        /// Place type
        ///</summary>
        [JsonProperty("type")]
        public String Type { get; set; }
    }
}