using System;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace VkLib.Types.Users 
{
    public class UserXtrCounters : VkLib.Types.Users.UserFull
    {
        /// <summary>
        /// Property
        /// </summary>
        [JsonProperty("counters")]
        public VkLib.Types.Users.UserCounters Counters { get; set; }

    }
}
