using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace VkApi.Wrapper.Objects
{
    public class UtilsStats
    {
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