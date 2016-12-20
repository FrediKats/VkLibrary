using System;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace VkLib.Types.Friends 
{
    public class UserXtrPhone : VkLib.Types.Users.UserFull
    {
        /// <summary>
        /// User phone
        /// </summary>
        [JsonProperty("phone")]
        public string Phone { get; set; }

    }
}
