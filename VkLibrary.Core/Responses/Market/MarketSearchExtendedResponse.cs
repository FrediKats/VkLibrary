using Newtonsoft.Json;
using VkApi.Wrapper.Types.Market;

namespace VkApi.Wrapper.Responses.Market
{
    public class MarketSearchExtendedResponse
    {
        ///<summary>
        /// Total number
        ///</summary>
        [JsonProperty("count")]
        public int Count { get; set; }
        [JsonProperty("items")]
        public MarketMarketItemFull[] Items { get; set; }
    }
}