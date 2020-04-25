using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace VkApi.Wrapper.Objects
{
    public class MarketPrice
    {
        ///<summary>
        /// Amount
        ///</summary>
        [JsonProperty("amount")]
        public String Amount { get; set; }
        [JsonProperty("currency")]
        public MarketCurrency Currency { get; set; }
        [JsonProperty("discount_rate")]
        public int DiscountRate { get; set; }
        [JsonProperty("old_amount")]
        public String OldAmount { get; set; }

        ///<summary>
        /// Text
        ///</summary>
        [JsonProperty("text")]
        public String Text { get; set; }
    }
}