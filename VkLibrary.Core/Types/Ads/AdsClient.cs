using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace VkLibrary.Core.Objects
{
    public class AdsClient
    {
        ///<summary>
        /// Client's total limit, rubles
        ///</summary>
        [JsonProperty("all_limit")]
        public String AllLimit { get; set; }

        ///<summary>
        /// Client's day limit, rubles
        ///</summary>
        [JsonProperty("day_limit")]
        public String DayLimit { get; set; }

        ///<summary>
        /// Client ID
        ///</summary>
        [JsonProperty("id")]
        public int Id { get; set; }

        ///<summary>
        /// Client name
        ///</summary>
        [JsonProperty("name")]
        public String Name { get; set; }
    }
}