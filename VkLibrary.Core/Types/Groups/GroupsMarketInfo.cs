using System;
using Newtonsoft.Json;
using VkApi.Wrapper.Types.Market;

namespace VkApi.Wrapper.Types.Groups
{
    public class GroupsMarketInfo
    {
        ///<summary>
        /// Contact person ID
        ///</summary>
        [JsonProperty("contact_id")]
        public int ContactId { get; set; }
        [JsonProperty("currency")]
        public MarketCurrency Currency { get; set; }

        ///<summary>
        /// Currency name
        ///</summary>
        [JsonProperty("currency_text")]
        public String CurrencyText { get; set; }

        ///<summary>
        /// Information whether the market is enabled
        ///</summary>
        [JsonProperty("enabled")]
        public int Enabled { get; set; }

        ///<summary>
        /// Main market album ID
        ///</summary>
        [JsonProperty("main_album_id")]
        public int MainAlbumId { get; set; }

        ///<summary>
        /// Maximum price
        ///</summary>
        [JsonProperty("price_max")]
        public int PriceMax { get; set; }

        ///<summary>
        /// Minimum price
        ///</summary>
        [JsonProperty("price_min")]
        public int PriceMin { get; set; }
    }
}