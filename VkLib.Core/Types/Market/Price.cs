using System;
using Newtonsoft.Json;

namespace VkLib.Types.Market 
{
    public class Price
    {
        /// <summary>
        /// Text
        /// </summary>
        [JsonProperty("text")]
        public string Text { get; set; }

        /// <summary>
        /// Amount
        /// </summary>
        [JsonProperty("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// Property
        /// </summary>
        [JsonProperty("currency")]
        public Currency Currency { get; set; }

    }
}
