using Newtonsoft.Json;
using VkApi.Wrapper.Types.Account;

namespace VkApi.Wrapper.Responses.Account
{
    public class AccountGetActiveOffersResponse
    {
        ///<summary>
        /// Total number
        ///</summary>
        [JsonProperty("count")]
        public int Count { get; set; }
        [JsonProperty("items")]
        public AccountOffer[] Items { get; set; }
    }
}