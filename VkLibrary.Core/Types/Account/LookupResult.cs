using System.Collections.Generic;
using Newtonsoft.Json;

namespace VkLibrary.Core.Types.Account
{
    /// <summary>
    /// API LookupResult object.
    /// </summary>
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