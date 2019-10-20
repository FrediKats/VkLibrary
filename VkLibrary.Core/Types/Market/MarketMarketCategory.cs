using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace VkLibrary.Core.Objects
{
    public class MarketMarketCategory
    {
        ///<summary>
        /// Category ID
        ///</summary>
        [JsonProperty("id")]
        public int Id { get; set; }

        ///<summary>
        /// Category name
        ///</summary>
        [JsonProperty("name")]
        public String Name { get; set; }
        [JsonProperty("section")]
        public MarketSection Section { get; set; }
    }
}