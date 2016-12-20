using System;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace VkLib.Types.Account 
{
    public class UserXtrContact : VkLib.Types.Users.UserFull
    {
        /// <summary>
        /// Property
        /// </summary>
        [JsonProperty("sort_num")]
        public int? SortNum { get; set; }

        /// <summary>
        /// Property
        /// </summary>
        [JsonProperty("request_sent")]
        public int? RequestSent { get; set; }

        /// <summary>
        /// Property
        /// </summary>
        [JsonProperty("contact")]
        public string Contact { get; set; }

    }
}
