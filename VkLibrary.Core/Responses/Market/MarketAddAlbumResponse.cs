using Newtonsoft.Json;

namespace VkApi.Wrapper.Responses.Market
{
    public class MarketAddAlbumResponse
    {
        ///<summary>
        /// Album ID
        ///</summary>
        [JsonProperty("market_album_id")]
        public int MarketAlbumId { get; set; }
    }
}