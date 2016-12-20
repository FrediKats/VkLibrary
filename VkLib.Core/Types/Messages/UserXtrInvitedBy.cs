using System;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace VkLib.Types.Messages 
{
    public class UserXtrInvitedBy : VkLib.Types.Users.UserXtrType
    {
        /// <summary>
        /// ID of the inviter
        /// </summary>
        [JsonProperty("invited_by")]
        public int? InvitedBy { get; set; }

    }
}
