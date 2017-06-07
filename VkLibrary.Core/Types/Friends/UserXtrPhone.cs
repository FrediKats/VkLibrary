using Newtonsoft.Json;
using VkLibrary.Core.Types.Users;

namespace VkLibrary.Core.Types.Friends
{
    /// <summary>
    /// API UserXtrPhone object.
    /// </summary>
    public class UserXtrPhone : UserFull
    {
        /// <summary>
        /// User phone
        /// </summary>
        [JsonProperty("phone")]
        public string Phone { get; set; }
    }
}