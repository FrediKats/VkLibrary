using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace VkApi.Wrapper.Objects
{
    public class BaseLinkProduct
    {
        [JsonProperty("price")]
        public MarketPrice Price { get; set; }
        [JsonProperty("merchant")]
        public String Merchant { get; set; }
        [JsonProperty("orders_count")]
        public int OrdersCount { get; set; }
    }
}