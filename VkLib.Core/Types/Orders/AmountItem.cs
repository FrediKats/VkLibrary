using System;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace VkLib.Types.Orders 
{
    public class AmountItem
    {
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

        /// <summary>
        /// Amount description
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }

    }
}
