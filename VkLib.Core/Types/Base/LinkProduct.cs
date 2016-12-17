using System;
using Newtonsoft.Json;

namespace VkLib.Types.Base 
{
    public class LinkProduct
    {
        /// <summary>
        /// Property
        /// </summary>
        [JsonProperty("price")]
        public Price Price { get; set; }

    }
}
