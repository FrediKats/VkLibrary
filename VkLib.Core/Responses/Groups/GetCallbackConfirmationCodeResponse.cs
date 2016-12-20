using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using VkLib.Types;

namespace VkLib.Responses.Groups
{
    public class GetCallbackConfirmationCodeResponse
    {
        /// <summary>
        /// Confirmation code
        /// </summary>
        [JsonProperty("code")]
        public string Code { get; set; }

    }
}
