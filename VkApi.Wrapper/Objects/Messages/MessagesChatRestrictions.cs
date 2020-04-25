using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace VkApi.Wrapper.Objects
{
    public class MessagesChatRestrictions
    {
        ///<summary>
        /// Only admins can promote users to admins
        ///</summary>
        [JsonProperty("admins_promote_users")]
        public Boolean AdminsPromoteUsers { get; set; }

        ///<summary>
        /// Only admins can change chat info
        ///</summary>
        [JsonProperty("only_admins_edit_info")]
        public Boolean OnlyAdminsEditInfo { get; set; }

        ///<summary>
        /// Only admins can edit pinned message
        ///</summary>
        [JsonProperty("only_admins_edit_pin")]
        public Boolean OnlyAdminsEditPin { get; set; }

        ///<summary>
        /// Only admins can invite users to this chat
        ///</summary>
        [JsonProperty("only_admins_invite")]
        public Boolean OnlyAdminsInvite { get; set; }

        ///<summary>
        /// Only admins can kick users from this chat
        ///</summary>
        [JsonProperty("only_admins_kick")]
        public Boolean OnlyAdminsKick { get; set; }
    }
}