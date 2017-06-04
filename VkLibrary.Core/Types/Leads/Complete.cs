using Newtonsoft.Json;

namespace VkLibrary.Core.Types.Leads
{
    public class Complete
    {
        /// <summary>
        /// Property
        /// </summary>
        [JsonProperty("success")]
        public int? Success { get; set; }

        /// <summary>
        /// Information whether test mode is enabled
        /// </summary>
        [JsonProperty("test_mode")]
        public int? TestMode { get; set; }

        /// <summary>
        /// Amount of spent votes
        /// </summary>
        [JsonProperty("spent")]
        public int? Spent { get; set; }

        /// <summary>
        /// Offer cost
        /// </summary>
        [JsonProperty("cost")]
        public int? Cost { get; set; }

        /// <summary>
        /// Offer limit
        /// </summary>
        [JsonProperty("limit")]
        public int? Limit { get; set; }
    }
}