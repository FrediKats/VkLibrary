using System.Collections.Generic;
using Newtonsoft.Json;
using VkLibrary.Core.Types.Users;

namespace VkLibrary.Core.Types.Friends
{
    /// <summary>
    /// API UserXtrLists object.
    /// </summary>
    public class UserXtrLists : UserFull
    {
        /// <summary>
        /// Property
        /// </summary>
        [JsonProperty("lists")]
        public IEnumerable<int?> Lists { get; set; }
    }
}