using Newtonsoft.Json;
using VkLibrary.Core.Types.Users;

namespace VkLibrary.Core.Types.Account
{
    /// <summary>
    /// API UserXtrContact object.
    /// </summary>
    public class UserXtrContact : UserFull
    {
        /// <summary>
        /// Property
        /// </summary>
        [JsonProperty("contact")]
        public string Contact { get; set; }

        /// <summary>
        /// Property
        /// </summary>
        [JsonProperty("sort_num")]
        public int? SortNum { get; set; }

        /// <summary>
        /// Property
        /// </summary>
        [JsonProperty("request_sent")]
        public int? RequestSent { get; set; }
    }
}