using System;
using Newtonsoft.Json;

namespace VkLib.Types.Ads 
{
    public class Users
    {
        /// <summary>
        /// Property
        /// </summary>
        [JsonProperty("accesses")]
        public IEnumerable<Accesses> Accesses { get; set; }

        /// <summary>
        /// User ID
        /// </summary>
        [JsonProperty("user_id")]
        public int? UserId { get; set; }

    }
}
