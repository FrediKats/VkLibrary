using Newtonsoft.Json;
using VkLibrary.Core.Objects;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace VkLibrary.Core.Responses
{
    public class MarketAddResponse
    {
        ///<summary>
        /// Item ID
        ///</summary>
        [JsonProperty("market_item_id")]
        public int MarketItemId { get; set; }
    }
}