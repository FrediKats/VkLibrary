using System;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace VkLib.Types.Groups 
{
    public class UserXtrRole : VkLib.Types.Users.UserFull
    {
        /// <summary>
        /// Property
        /// </summary>
        [JsonProperty("role")]
        public string Role { get; set; }

    }
}
