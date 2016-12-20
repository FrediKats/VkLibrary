using System;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace VkLib.Types.Base 
{
    public class LinkProduct
    {
        /// <summary>
        /// Property
        /// </summary>
        [JsonProperty("price")]
        public VkLib.Types.Market.Price Price { get; set; }

    }
}
