using System;
using Newtonsoft.Json;

namespace VkApi.Wrapper.Types.Orders
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