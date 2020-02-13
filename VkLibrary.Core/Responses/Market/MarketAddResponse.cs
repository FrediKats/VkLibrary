using Newtonsoft.Json;

namespace VkApi.Wrapper.Responses.Market
{
    public class MarketAddResponse
    {
        ///<summary>
        /// Item ID
        ///</summary>
        [JsonProperty("market_item_id")]
        public int MarketItemId { get; set; }
    }
}