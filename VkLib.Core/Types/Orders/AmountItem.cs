using System;
using Newtonsoft.Json;

namespace VkLib.Types.Orders 
{
    public class AmountItem
    {
        /// <summary>
        /// Amount description
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        /// Votes amount in user's currency
        /// </summary>
        [JsonProperty("amount")]
        public int? Amount { get; set; }

        /// <summary>
        /// Votes number
        /// </summary>
        [JsonProperty("votes")]
        public string Votes { get; set; }

    }
}
