using System;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace VkLib.Types.Groups 
{
    public class MemberStatus
    {
        /// <summary>
        /// User ID
        /// </summary>
        [JsonProperty("user_id")]
        public int? UserId { get; set; }

        /// <summary>
        /// Information whether user is a member of the group
        /// </summary>
        [JsonProperty("member")]
        public int? Member { get; set; }

    }
}
