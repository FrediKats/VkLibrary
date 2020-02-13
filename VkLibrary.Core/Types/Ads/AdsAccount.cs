using Newtonsoft.Json;

namespace VkApi.Wrapper.Types.Ads
{
    public class AdsAccount
    {
        [JsonProperty("access_role")]
        public AdsAccessRole AccessRole { get; set; }

        ///<summary>
        /// Account ID
        ///</summary>
        [JsonProperty("account_id")]
        public int AccountId { get; set; }

        ///<summary>
        /// Information whether account is active
        ///</summary>
        [JsonProperty("account_status")]
        public int AccountStatus { get; set; }
        [JsonProperty("account_type")]
        public AdsAccountType AccountType { get; set; }
    }
}