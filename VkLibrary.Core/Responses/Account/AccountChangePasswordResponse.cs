using System;
using Newtonsoft.Json;

namespace VkApi.Wrapper.Responses.Account
{
    public class AccountChangePasswordResponse
    {
        ///<summary>
        /// New token
        ///</summary>
        [JsonProperty("token")]
        public String Token { get; set; }

        ///<summary>
        /// New secret
        ///</summary>
        [JsonProperty("secret")]
        public String Secret { get; set; }
    }
}