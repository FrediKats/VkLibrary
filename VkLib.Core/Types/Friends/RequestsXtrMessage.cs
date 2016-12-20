using System;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace VkLib.Types.Friends 
{
    public class RequestsXtrMessage
    {
        /// <summary>
        /// User ID
        /// </summary>
        [JsonProperty("user_id")]
        public int? UserId { get; set; }

        /// <summary>
        /// Property
        /// </summary>
        [JsonProperty("mutual")]
        public VkLib.Types.Friends.RequestsMutual Mutual { get; set; }

        /// <summary>
        /// Message sent with a request
        /// </summary>
        [JsonProperty("message")]
        public string Message { get; set; }

        /// <summary>
        /// ID of the user by whom friend has been suggested
        /// </summary>
        [JsonProperty("from")]
        public string From { get; set; }

    }
}
