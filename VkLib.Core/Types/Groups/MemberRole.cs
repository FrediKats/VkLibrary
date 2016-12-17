using System;
using Newtonsoft.Json;

namespace VkLib.Types.Groups 
{
    public class MemberRole
    {
        /// <summary>
        /// User's credentials as community admin
        /// </summary>
        [JsonProperty("role")]
        public string Role { get; set; }

        /// <summary>
        /// User ID
        /// </summary>
        [JsonProperty("id")]
        public int? Id { get; set; }

    }
}
