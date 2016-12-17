using System;
using Newtonsoft.Json;

namespace VkLib.Types.Groups 
{
    public class MemberStatusFull
    {
        /// <summary>
        /// Information whether user is a member of the group
        /// </summary>
        [JsonProperty("member")]
        public BoolInt Member { get; set; }

        /// <summary>
        /// Information whether user has send request to the group
        /// </summary>
        [JsonProperty("request")]
        public BoolInt Request { get; set; }

        /// <summary>
        /// User ID
        /// </summary>
        [JsonProperty("user_id")]
        public int? UserId { get; set; }

        /// <summary>
        /// Information whether user has been invited to the group
        /// </summary>
        [JsonProperty("invitation")]
        public BoolInt Invitation { get; set; }

    }
}
