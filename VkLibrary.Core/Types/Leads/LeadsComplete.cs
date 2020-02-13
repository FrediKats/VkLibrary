using Newtonsoft.Json;
using VkApi.Wrapper.Types.Base;

namespace VkApi.Wrapper.Types.Leads
{
    public class LeadsComplete
    {
        ///<summary>
        /// Offer cost
        ///</summary>
        [JsonProperty("cost")]
        public int Cost { get; set; }

        ///<summary>
        /// Offer limit
        ///</summary>
        [JsonProperty("limit")]
        public int Limit { get; set; }

        ///<summary>
        /// Amount of spent votes
        ///</summary>
        [JsonProperty("spent")]
        public int Spent { get; set; }
        [JsonProperty("success")]
        public BaseOkResponse Success { get; set; }

        ///<summary>
        /// Information whether test mode is enabled
        ///</summary>
        [JsonProperty("test_mode")]
        public int TestMode { get; set; }
    }
}