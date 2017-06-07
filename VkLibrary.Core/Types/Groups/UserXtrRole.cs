using Newtonsoft.Json;
using VkLibrary.Core.Types.Users;

namespace VkLibrary.Core.Types.Groups
{
    /// <summary>
    /// API UserXtrRole object.
    /// </summary>
    public class UserXtrRole : UserFull
    {
        /// <summary>
        /// Property
        /// </summary>
        [JsonProperty("role")]
        public string Role { get; set; }
    }
}