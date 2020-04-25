using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace VkApi.Wrapper.Objects
{
    public class MarketCurrency
    {
        ///<summary>
        /// Currency ID
        ///</summary>
        [JsonProperty("id")]
        public int Id { get; set; }

        ///<summary>
        /// Currency sign
        ///</summary>
        [JsonProperty("name")]
        public String Name { get; set; }
    }
}