using System;
using Newtonsoft.Json;

namespace VkLib.Types.Orders 
{
    public class Amount
    {
        /// <summary>
        /// Property
        /// </summary>
        [JsonProperty("amounts")]
        public IEnumerable<AmountItem> Amounts { get; set; }

        /// <summary>
        /// Currency name
        /// </summary>
        [JsonProperty("currency")]
        public string Currency { get; set; }

    }
}
