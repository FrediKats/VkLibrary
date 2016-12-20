using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using VkLib.Types;

namespace VkLib.Responses.Market
{
    public class AddResponse
    {
        /// <summary>
        /// Item ID
        /// </summary>
        [JsonProperty("market_item_id")]
        public int? MarketItemId { get; set; }

    }
}
