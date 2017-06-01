using Newtonsoft.Json;
using VkLib.Types.Users;

namespace VkLib.Types.Groups
{
    public class UserXtrRole : UserFull
    {
        /// <summary>
        ///     Property
        /// </summary>
        [JsonProperty("role")]
        public string Role { get; set; }
    }
}