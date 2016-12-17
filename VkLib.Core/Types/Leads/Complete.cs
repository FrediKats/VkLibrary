using System;
using Newtonsoft.Json;

namespace VkLib.Types.Leads 
{
    public class Complete
    {
        /// <summary>
        /// Offer cost
        /// </summary>
        [JsonProperty("cost")]
        public int? Cost { get; set; }

        /// <summary>
        /// Amount of spent votes
        /// </summary>
        [JsonProperty("spent")]
        public int? Spent { get; set; }

        /// <summary>
        /// Information whether test mode is enabled
        /// </summary>
        [JsonProperty("test_mode")]
        public BoolInt TestMode { get; set; }

        /// <summary>
        /// Property
        /// </summary>
        [JsonProperty("success")]
        public OkResponse Success { get; set; }

        /// <summary>
        /// Offer limit
        /// </summary>
        [JsonProperty("limit")]
        public int? Limit { get; set; }

    }
}
