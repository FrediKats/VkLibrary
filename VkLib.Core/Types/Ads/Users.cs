using System;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace VkLib.Types.Ads 
{
    public class Users
    {
        /// <summary>
        /// User ID
        /// </summary>
        [JsonProperty("user_id")]
        public int? UserId { get; set; }

        /// <summary>
        /// Property
        /// </summary>
        [JsonProperty("accesses")]
        public IEnumerable<VkLib.Types.Ads.Accesses> Accesses { get; set; }

    }
}
