using System;
using Newtonsoft.Json;

namespace VkApi.Wrapper.Types.Account
{
    public class AccountNameRequest
    {
        ///<summary>
        /// First name in request
        ///</summary>
        [JsonProperty("first_name")]
        public String FirstName { get; set; }

        ///<summary>
        /// Request ID needed to cancel the request
        ///</summary>
        [JsonProperty("id")]
        public int Id { get; set; }

        ///<summary>
        /// Last name in request
        ///</summary>
        [JsonProperty("last_name")]
        public String LastName { get; set; }
        [JsonProperty("status")]
        public AccountNameRequestStatus Status { get; set; }
        [JsonProperty("lang")]
        public String Lang { get; set; }
    }
}