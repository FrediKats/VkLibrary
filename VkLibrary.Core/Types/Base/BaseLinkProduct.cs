using System;
using Newtonsoft.Json;
using VkApi.Wrapper.Types.Market;

namespace VkApi.Wrapper.Types.Base
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