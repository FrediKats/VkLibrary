using System;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace VkLib.Types.Ads 
{
    public class Users
    {
        /// <summary>
        /// Property
        /// </summary>
        [JsonProperty("accesses")]
        public IEnumerable<VkLib.Types.Ads.Accesses> Accesses_ { get; set; }

        /// <summary>
        /// User ID
        /// </summary>
        [JsonProperty("user_id")]
        public int? UserId { get; set; }

    }
}
