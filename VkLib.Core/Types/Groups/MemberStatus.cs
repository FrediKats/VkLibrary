using System;
using Newtonsoft.Json;

namespace VkLib.Types.Groups 
{
    public class MemberStatus
    {
        /// <summary>
        /// Information whether user is a member of the group
        /// </summary>
        [JsonProperty("member")]
        public BoolInt Member { get; set; }

        /// <summary>
        /// User ID
        /// </summary>
        [JsonProperty("user_id")]
        public int? UserId { get; set; }

    }
}
