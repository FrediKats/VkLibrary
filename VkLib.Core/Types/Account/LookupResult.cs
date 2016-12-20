using System;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace VkLib.Types.Account 
{
    public class LookupResult
    {
        /// <summary>
        /// Property
        /// </summary>
        [JsonProperty("other")]
        public IEnumerable<VkLib.Types.Account.OtherContact> Other { get; set; }

        /// <summary>
        /// Property
        /// </summary>
        [JsonProperty("found")]
        public IEnumerable<VkLib.Types.Account.UserXtrContact> Found { get; set; }

    }
}
