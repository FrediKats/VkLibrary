using Newtonsoft.Json;
using VkApi.Wrapper.Objects;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace VkApi.Wrapper.Responses
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