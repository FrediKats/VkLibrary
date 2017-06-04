using Newtonsoft.Json;

namespace VkLibrary.Core.Types.Market
{
    public class Price
    {
        /// <summary>
        /// Amount
        /// </summary>
        [JsonProperty("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// Property
        /// </summary>
        [JsonProperty("currency")]
        public Currency Currency { get; set; }

        /// <summary>
        /// Text
        /// </summary>
        [JsonProperty("text")]
        public string Text { get; set; }
    }
}