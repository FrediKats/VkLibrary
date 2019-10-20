using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace VkLibrary.Core.Objects
{
    public class GroupsMemberStatusFull
    {
        ///<summary>
        /// Information whether user can be invited
        ///</summary>
        [JsonProperty("can_invite")]
        public int CanInvite { get; set; }

        ///<summary>
        /// Information whether user's invite to the group can be recalled
        ///</summary>
        [JsonProperty("can_recall")]
        public int CanRecall { get; set; }

        ///<summary>
        /// Information whether user has been invited to the group
        ///</summary>
        [JsonProperty("invitation")]
        public int Invitation { get; set; }

        ///<summary>
        /// Information whether user is a member of the group
        ///</summary>
        [JsonProperty("member")]
        public int Member { get; set; }

        ///<summary>
        /// Information whether user has send request to the group
        ///</summary>
        [JsonProperty("request")]
        public int Request { get; set; }

        ///<summary>
        /// User ID
        ///</summary>
        [JsonProperty("user_id")]
        public int UserId { get; set; }
    }
}