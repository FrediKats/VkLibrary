using Newtonsoft.Json;
using VkLibrary.Core.Types.Market;

namespace VkLibrary.Core.Types.Groups
{
    public class MarketInfo
    {
        /// <summary>
        /// Information whether the market is enabled
        /// </summary>
        [JsonProperty("enabled")]
        public int? Enabled { get; set; }

        /// <summary>
        /// Minimum price
        /// </summary>
        [JsonProperty("price_min")]
        public int? PriceMin { get; set; }

        /// <summary>
        /// Main market album ID
        /// </summary>
        [JsonProperty("main_album_id")]
        public int? MainAlbumId { get; set; }

        /// <summary>
        /// Maximum price
        /// </summary>
        [JsonProperty("price_max")]
        public int? PriceMax { get; set; }

        /// <summary>
        /// Currency name
        /// </summary>
        [JsonProperty("currency_text")]
        public string CurrencyText { get; set; }

        /// <summary>
        /// Property
        /// </summary>
        [JsonProperty("currency")]
        public Currency Currency { get; set; }

        /// <summary>
        /// Contact person ID
        /// </summary>
        [JsonProperty("contact_id")]
        public int? ContactId { get; set; }
    }
}