using Newtonsoft.Json;
using VkLib.Types.Users;

namespace VkLib.Types.Friends
{
    public class UserXtrPhone : UserFull
    {
        /// <summary>
        ///     User phone
        /// </summary>
        [JsonProperty("phone")]
        public string Phone { get; set; }
    }
}