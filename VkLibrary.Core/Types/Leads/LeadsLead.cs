using Newtonsoft.Json;

namespace VkApi.Wrapper.Types.Leads
{
    public class LeadsLead
    {
        ///<summary>
        /// Completed offers number
        ///</summary>
        [JsonProperty("completed")]
        public int Completed { get; set; }

        ///<summary>
        /// Offer cost
        ///</summary>
        [JsonProperty("cost")]
        public int Cost { get; set; }
        [JsonProperty("days")]
        public LeadsLeadDays Days { get; set; }

        ///<summary>
        /// Impressions number
        ///</summary>
        [JsonProperty("impressions")]
        public int Impressions { get; set; }

        ///<summary>
        /// Lead limit
        ///</summary>
        [JsonProperty("limit")]
        public int Limit { get; set; }

        ///<summary>
        /// Amount of spent votes
        ///</summary>
        [JsonProperty("spent")]
        public int Spent { get; set; }

        ///<summary>
        /// Started offers number
        ///</summary>
        [JsonProperty("started")]
        public int Started { get; set; }
    }
}