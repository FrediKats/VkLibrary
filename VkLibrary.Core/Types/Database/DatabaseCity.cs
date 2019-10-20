using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace VkLibrary.Core.Objects
{
    public class DatabaseCity
    {
        ///<summary>
        /// Area title
        ///</summary>
        [JsonProperty("area")]
        public String Area { get; set; }

        ///<summary>
        /// Region title
        ///</summary>
        [JsonProperty("region")]
        public String Region { get; set; }

        ///<summary>
        /// Information whether the city is included in important cities list
        ///</summary>
        [JsonProperty("important")]
        public int Important { get; set; }
    }
}