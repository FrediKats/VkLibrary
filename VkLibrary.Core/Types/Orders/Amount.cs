using System.Collections.Generic;
using Newtonsoft.Json;

namespace VkLibrary.Core.Types.Orders
{
    public class Amount
    {
        /// <summary>
        /// Currency name
        /// </summary>
        [JsonProperty("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// Property
        /// </summary>
        [JsonProperty("amounts")]
        public IEnumerable<AmountItem> Amounts { get; set; }
    }
}