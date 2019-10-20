using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace VkLibrary.Core.Objects
{
    public class GroupsUserXtrRole
    {
        [JsonProperty("role")]
        public GroupsRoleOptions Role { get; set; }
    }
}