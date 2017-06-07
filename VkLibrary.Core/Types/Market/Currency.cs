using Newtonsoft.Json;

namespace VkLibrary.Core.Types.Market
{
    /// <summary>
    /// API Currency object.
    /// </summary>
    public class Currency
    {
        /// <summary>
        /// Currency ID
        /// </summary>
        [JsonProperty("id")]
        public int? Id { get; set; }

        /// <summary>
        /// Currency sign
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }
    }
}