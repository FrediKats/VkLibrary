using System;
using Newtonsoft.Json;

namespace VkLib.Types.Account 
{
    public class LookupResult
    {
        /// <summary>
        /// Property
        /// </summary>
        [JsonProperty("other")]
        public IEnumerable<OtherContact> Other { get; set; }

        /// <summary>
        /// Property
        /// </summary>
        [JsonProperty("found")]
        public IEnumerable<UserXtrContact> Found { get; set; }

    }
}
