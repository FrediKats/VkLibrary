using Newtonsoft.Json;
using VkLibrary.Core.Types.Market;

namespace VkLibrary.Core.Types.Base
{
    /// <summary>
    /// API LinkProduct object.
    /// </summary>
    public class LinkProduct
    {
        /// <summary>
        /// Property
        /// </summary>
        [JsonProperty("price")]
        public Price Price { get; set; }
    }
}