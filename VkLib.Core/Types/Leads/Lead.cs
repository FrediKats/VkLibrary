using System;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace VkLib.Types.Leads 
{
    public class Lead
    {
        /// <summary>
        /// Impressions number
        /// </summary>
        [JsonProperty("impressions")]
        public int? Impressions_ { get; set; }

        /// <summary>
        /// Completed offers number
        /// </summary>
        [JsonProperty("completed")]
        public int? Completed_ { get; set; }

        /// <summary>
        /// Amount of spent votes
        /// </summary>
        [JsonProperty("spent")]
        public int? Spent_ { get; set; }

        /// <summary>
        /// Lead limit
        /// </summary>
        [JsonProperty("limit")]
        public int? Limit_ { get; set; }

        /// <summary>
        /// Started offers number
        /// </summary>
        [JsonProperty("started")]
        public int? Started_ { get; set; }

        /// <summary>
        /// Property
        /// </summary>
        [JsonProperty("days")]
        public VkLib.Types.Leads.LeadDays Days_ { get; set; }

        /// <summary>
        /// Offer cost
        /// </summary>
        [JsonProperty("cost")]
        public int? Cost_ { get; set; }

    }
}
