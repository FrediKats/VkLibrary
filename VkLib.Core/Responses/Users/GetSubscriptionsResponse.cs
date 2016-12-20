using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using VkLib.Types;

namespace VkLib.Responses.Users
{
    public class GetSubscriptionsResponse
    {
        /// <summary>
        /// None
        /// </summary>
        [JsonProperty("users")]
        public VkLib.Types.Users.UsersArray Users { get; set; }

        /// <summary>
        /// None
        /// </summary>
        [JsonProperty("groups")]
        public VkLib.Types.Groups.GroupsArray Groups { get; set; }

    }
}
