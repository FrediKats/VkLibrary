using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace VkApi.Wrapper.Objects
{
    public class GroupsMemberRole
    {
        ///<summary>
        /// User ID
        ///</summary>
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("permissions")]
        public GroupsMemberRolePermission[] Permissions { get; set; }
        [JsonProperty("role")]
        public GroupsMemberRoleStatus Role { get; set; }
    }
}