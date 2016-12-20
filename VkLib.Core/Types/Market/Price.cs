using System;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace VkLib.Types.Market 
{
    public class Price
    {
        /// <summary>
        /// Amount
        /// </summary>
        [JsonProperty("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// Property
        /// </summary>
        [JsonProperty("currency")]
        public VkLib.Types.Market.Currency Currency { get; set; }

        /// <summary>
        /// Text
        /// </summary>
        [JsonProperty("text")]
        public string Text { get; set; }

    }
}
