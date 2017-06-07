using Newtonsoft.Json;

namespace VkLibrary.Core.Responses.Market
{
    /// <summary>
    /// API AddResponse.
    /// </summary>
    public class AddResponse
    {
        /// <summary>
        /// Item ID
        /// </summary>
        [JsonProperty("market_item_id")]
        public int? MarketItemId { get; set; }
    }
}