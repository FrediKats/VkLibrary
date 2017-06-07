using Newtonsoft.Json;

namespace VkLibrary.Core.Responses.Market
{
    /// <summary>
    /// API AddAlbumResponse.
    /// </summary>
    public class AddAlbumResponse
    {
        /// <summary>
        /// Album ID
        /// </summary>
        [JsonProperty("market_album_id")]
        public int? MarketAlbumId { get; set; }
    }
}