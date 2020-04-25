using Newtonsoft.Json;
using VkApi.Wrapper.Objects;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace VkApi.Wrapper.Responses
{
    public class UsersGetSubscriptionsResponse
    {
        [JsonProperty("users")]
        public UsersUsersArray Users { get; set; }
        [JsonProperty("groups")]
        public GroupsGroupsArray Groups { get; set; }
    }
}