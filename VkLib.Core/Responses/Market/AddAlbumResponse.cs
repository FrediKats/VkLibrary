using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using VkLib.Types;

namespace VkLib.Responses.Market
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
