using System;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace VkLib.Types.Friends 
{
    public class Requests
    {
        /// <summary>
        /// Property
        /// </summary>
        [JsonProperty("mutual")]
        public VkLib.Types.Friends.RequestsMutual Mutual_ { get; set; }

        /// <summary>
        /// User ID
        /// </summary>
        [JsonProperty("user_id")]
        public int? UserId { get; set; }

        /// <summary>
        /// ID of the user by whom friend has been suggested
        /// </summary>
        [JsonProperty("from")]
        public string From_ { get; set; }

    }
}
