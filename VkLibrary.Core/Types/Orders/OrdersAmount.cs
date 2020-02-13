using System;
using Newtonsoft.Json;

namespace VkApi.Wrapper.Types.Orders
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