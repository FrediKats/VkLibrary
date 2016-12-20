using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using VkLib.Types;

namespace VkLib.Responses.Auth
{
    public class SignupResponse
    {
        /// <summary>
        /// Parameter to retry
        /// </summary>
        [JsonProperty("sid")]
        public string Sid { get; set; }

    }
}
