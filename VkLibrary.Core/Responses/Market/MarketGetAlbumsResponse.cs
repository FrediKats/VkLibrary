using Newtonsoft.Json;
using VkApi.Wrapper.Types.Market;

namespace VkApi.Wrapper.Responses.Market
{
    public class MarketGetAlbumsResponse
    {
        ///<summary>
        /// Total number
        ///</summary>
        [JsonProperty("count")]
        public int Count { get; set; }
        [JsonProperty("items")]
        public MarketMarketAlbum[] Items { get; set; }
    }
}