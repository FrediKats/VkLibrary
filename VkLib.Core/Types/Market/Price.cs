using System;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace VkLib.Types.Market 
{
    public class Price
    {
        /// <summary>
        /// Property
        /// </summary>
        [JsonProperty("currency")]
        public VkLib.Types.Market.Currency Currency_ { get; set; }

        /// <summary>
        /// Amount
        /// </summary>
        [JsonProperty("amount")]
        public string Amount_ { get; set; }

        /// <summary>
        /// Text
        /// </summary>
        [JsonProperty("text")]
        public string Text_ { get; set; }

    }
}
