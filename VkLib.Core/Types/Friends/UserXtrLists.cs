using System;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace VkLib.Types.Friends 
{
    public class UserXtrLists : VkLib.Types.Users.UserFull
    {
        /// <summary>
        /// Property
        /// </summary>
        [JsonProperty("lists")]
        public IEnumerable<int?> Lists { get; set; }

    }
}
