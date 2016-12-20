using System;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace VkLib.Types.Groups 
{
    public class MemberStatusFull
    {
        /// <summary>
        /// User ID
        /// </summary>
        [JsonProperty("user_id")]
        public int? UserId { get; set; }

        /// <summary>
        /// Information whether user has send request to the group
        /// </summary>
        [JsonProperty("request")]
        public int? Request { get; set; }

        /// <summary>
        /// Information whether user is a member of the group
        /// </summary>
        [JsonProperty("member")]
        public int? Member { get; set; }

        /// <summary>
        /// Information whether user has been invited to the group
        /// </summary>
        [JsonProperty("invitation")]
        public int? Invitation { get; set; }

    }
}
