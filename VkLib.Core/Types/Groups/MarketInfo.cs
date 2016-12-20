using System;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace VkLib.Types.Groups 
{
    public class MarketInfo
    {
        /// <summary>
        /// Main market album ID
        /// </summary>
        [JsonProperty("main_album_id")]
        public int? MainAlbumId { get; set; }

        /// <summary>
        /// Minimum price
        /// </summary>
        [JsonProperty("price_min")]
        public int? PriceMin_ { get; set; }

        /// <summary>
        /// Currency name
        /// </summary>
        [JsonProperty("currency_text")]
        public string CurrencyText_ { get; set; }

        /// <summary>
        /// Contact person ID
        /// </summary>
        [JsonProperty("contact_id")]
        public int? ContactId_ { get; set; }

        /// <summary>
        /// Property
        /// </summary>
        [JsonProperty("currency")]
        public VkLib.Types.Market.Currency Currency { get; set; }

        /// <summary>
        /// Information whether the market is enabled
        /// </summary>
        [JsonProperty("enabled")]
        public int? Enabled { get; set; }

        /// <summary>
        /// Maximum price
        /// </summary>
        [JsonProperty("price_max")]
        public int? PriceMax_ { get; set; }

    }
}
