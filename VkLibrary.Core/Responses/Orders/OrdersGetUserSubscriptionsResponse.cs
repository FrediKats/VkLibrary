using Newtonsoft.Json;
using VkApi.Wrapper.Types.Orders;

namespace VkApi.Wrapper.Responses.Orders
{
    public class OrdersGetUserSubscriptionsResponse
    {
        ///<summary>
        /// Total number
        ///</summary>
        [JsonProperty("count")]
        public int Count { get; set; }
        [JsonProperty("items")]
        public OrdersSubscription[] Items { get; set; }
    }
}