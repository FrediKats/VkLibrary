using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace VkLibrary.Core.Objects
{
    public class UtilsStatsExtended
    {
        [JsonProperty("cities")]
        public UtilsStatsCity[] Cities { get; set; }
        [JsonProperty("countries")]
        public UtilsStatsCountry[] Countries { get; set; }
        [JsonProperty("sex_age")]
        public UtilsStatsSexAge[] SexAge { get; set; }

        ///<summary>
        /// Start time
        ///</summary>
        [JsonProperty("timestamp")]
        public int Timestamp { get; set; }

        ///<summary>
        /// Total views number
        ///</summary>
        [JsonProperty("views")]
        public int Views { get; set; }
    }
}