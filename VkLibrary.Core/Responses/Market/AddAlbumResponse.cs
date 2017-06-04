using Newtonsoft.Json;

namespace VkLibrary.Core.Responses.Market
{
    public class AddAlbumResponse
    {
        /// <summary>
        /// Album ID
        /// </summary>
        [JsonProperty("market_album_id")]
        public int? MarketAlbumId { get; set; }
    }
}