using System;
using Newtonsoft.Json;

namespace VkApi.Wrapper.Types.Market
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