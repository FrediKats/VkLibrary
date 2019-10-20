using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace VkLibrary.Core.Objects
{
    public class UtilsStatsCity
    {
        ///<summary>
        /// City ID
        ///</summary>
        [JsonProperty("city_id")]
        public int CityId { get; set; }

        ///<summary>
        /// Views number
        ///</summary>
        [JsonProperty("views")]
        public int Views { get; set; }
    }
}