using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace VkLibrary.Core.Objects
{
    public class UsersCropPhotoCrop
    {
        ///<summary>
        /// Coordinate X of the left upper corner
        ///</summary>
        [JsonProperty("x")]
        public double X { get; set; }

        ///<summary>
        /// Coordinate X of the right lower corner
        ///</summary>
        [JsonProperty("x2")]
        public double X2 { get; set; }

        ///<summary>
        /// Coordinate Y of the left upper corner
        ///</summary>
        [JsonProperty("y")]
        public double Y { get; set; }

        ///<summary>
        /// Coordinate Y of the right lower corner
        ///</summary>
        [JsonProperty("y2")]
        public double Y2 { get; set; }
    }
}