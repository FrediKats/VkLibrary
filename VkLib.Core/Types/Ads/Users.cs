using System.Collections.Generic;
using Newtonsoft.Json;

namespace VkLib.Types.Ads
{
    public class Users
    {
        /// <summary>
        ///     User ID
        /// </summary>
        [JsonProperty("user_id")]
        public int? UserId { get; set; }

        /// <summary>
        ///     Property
        /// </summary>
        [JsonProperty("accesses")]
        public IEnumerable<Accesses> Accesses { get; set; }
    }
}