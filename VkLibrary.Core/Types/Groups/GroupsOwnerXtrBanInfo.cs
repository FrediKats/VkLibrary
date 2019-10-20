using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace VkLibrary.Core.Objects
{
    public class GroupsOwnerXtrBanInfo
    {
        [JsonProperty("ban_info")]
        public GroupsBanInfo BanInfo { get; set; }

        ///<summary>
        /// Information about group if type = group
        ///</summary>
        [JsonProperty("group")]
        public GroupsGroup Group { get; set; }

        ///<summary>
        /// Information about group if type = profile
        ///</summary>
        [JsonProperty("profile")]
        public UsersUser Profile { get; set; }
        [JsonProperty("type")]
        public GroupsOwnerXtrBanInfoType Type { get; set; }
    }
}