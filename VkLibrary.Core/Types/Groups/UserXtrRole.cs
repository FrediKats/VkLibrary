using Newtonsoft.Json;
using VkLibrary.Core.Types.Users;

namespace VkLibrary.Core.Types.Groups
{
    public class UserXtrRole : UserFull
    {
        /// <summary>
        /// Property
        /// </summary>
        [JsonProperty("role")]
        public string Role { get; set; }
    }
}