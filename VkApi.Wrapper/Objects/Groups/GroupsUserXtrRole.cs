using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace VkApi.Wrapper.Objects
{
    public class GroupsUserXtrRole : UsersUserFull
    {
        [JsonProperty("role")]
        public GroupsRoleOptions Role { get; set; }
    }
}