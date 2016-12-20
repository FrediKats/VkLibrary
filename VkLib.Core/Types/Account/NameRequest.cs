using System;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace VkLib.Types.Account 
{
    public class NameRequest
    {
        /// <summary>
        /// Last name in request
        /// </summary>
        [JsonProperty("last_name")]
        public string LastName_ { get; set; }

        /// <summary>
        /// Request ID needed to cancel the request
        /// </summary>
        [JsonProperty("id")]
        public int? Id { get; set; }

        /// <summary>
        /// First name in request
        /// </summary>
        [JsonProperty("first_name")]
        public string FirstName_ { get; set; }

        /// <summary>
        /// Request status
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }

    }
}
