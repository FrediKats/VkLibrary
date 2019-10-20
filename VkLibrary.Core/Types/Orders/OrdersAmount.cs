using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace VkLibrary.Core.Objects
{
    public class OrdersAmount
    {
        [JsonProperty("amounts")]
        public OrdersAmountItem[] Amounts { get; set; }

        ///<summary>
        /// Currency name
        ///</summary>
        [JsonProperty("currency")]
        public String Currency { get; set; }
    }
}