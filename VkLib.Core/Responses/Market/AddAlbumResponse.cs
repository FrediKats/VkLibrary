using Newtonsoft.Json;

namespace VkLib.Responses.Market
{
    public class AddAlbumResponse
    {
        /// <summary>
        ///     Album ID
        /// </summary>
        [JsonProperty("market_album_id")]
        public int? MarketAlbumId { get; set; }
    }
}