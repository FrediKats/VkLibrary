using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using VkLib.Types;

namespace VkLib.Responses.Account
{
    public class ChangePasswordResponse
    {
        /// <summary>
        /// New secret
        /// </summary>
        [JsonProperty("secret")]
        public string Secret { get; set; }

        /// <summary>
        /// New token
        /// </summary>
        [JsonProperty("token")]
        public string Token { get; set; }

    }
}