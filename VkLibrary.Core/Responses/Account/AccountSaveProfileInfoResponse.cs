using Newtonsoft.Json;
using VkApi.Wrapper.Types.Account;

namespace VkApi.Wrapper.Responses.Account
{
    public class AccountSaveProfileInfoResponse
    {
        ///<summary>
        /// 1 if changes has been processed
        ///</summary>
        [JsonProperty("changed")]
        public int Changed { get; set; }
        [JsonProperty("name_request")]
        public AccountNameRequest NameRequest { get; set; }
    }
}