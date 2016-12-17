using System;
using Newtonsoft.Json;

namespace VkLib.Types.Account 
{
    public class NameRequest
    {
        /// <summary>
        /// Request ID needed to cancel the request
        /// </summary>
        [JsonProperty("id")]
        public int? Id { get; set; }

        /// <summary>
        /// First name in request
        /// </summary>
        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        /// <summary>
        /// Last name in request
        /// </summary>
        [JsonProperty("last_name")]
        public string LastName { get; set; }

        /// <summary>
        /// Request status
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }

    }
}
