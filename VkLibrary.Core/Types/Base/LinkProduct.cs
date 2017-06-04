using Newtonsoft.Json;
using VkLibrary.Core.Types.Market;

namespace VkLibrary.Core.Types.Base
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