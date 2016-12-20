using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using VkLib.Types;

namespace VkLib.Responses.Messages
{
    public class IsMessagesFromGroupAllowedResponse
    {
        /// <summary>
        /// None
        /// </summary>
        [JsonProperty("is_allowed")]
        public int IsAllowed { get; set; }

    }
}
