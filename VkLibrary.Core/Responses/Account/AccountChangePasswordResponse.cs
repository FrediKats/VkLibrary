using Newtonsoft.Json;
using VkLibrary.Core.Objects;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace VkLibrary.Core.Responses
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