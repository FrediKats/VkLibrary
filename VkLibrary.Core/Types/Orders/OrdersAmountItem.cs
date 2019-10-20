using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace VkLibrary.Core.Objects
{
    public class OrdersAmountItem
    {
        ///<summary>
        /// Votes amount in user's currency
        ///</summary>
        [JsonProperty("amount")]
        public int Amount { get; set; }

        ///<summary>
        /// Amount description
        ///</summary>
        [JsonProperty("description")]
        public String Description { get; set; }

        ///<summary>
        /// Votes number
        ///</summary>
        [JsonProperty("votes")]
        public String Votes { get; set; }
    }
}