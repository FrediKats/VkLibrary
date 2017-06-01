using System.Collections.Generic;
using Newtonsoft.Json;
using VkLib.Types.Users;

namespace VkLib.Types.Friends
{
    public class UserXtrLists : UserFull
    {
        /// <summary>
        ///     Property
        /// </summary>
        [JsonProperty("lists")]
        public IEnumerable<int?> Lists { get; set; }
    }
}