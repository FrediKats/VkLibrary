using Newtonsoft.Json;
using VkLib.Types.Users;

namespace VkLib.Types.Account
{
    public class UserXtrContact : UserFull
    {
        /// <summary>
        ///     Property
        /// </summary>
        [JsonProperty("contact")]
        public string Contact { get; set; }

        /// <summary>
        ///     Property
        /// </summary>
        [JsonProperty("sort_num")]
        public int? SortNum { get; set; }

        /// <summary>
        ///     Property
        /// </summary>
        [JsonProperty("request_sent")]
        public int? RequestSent { get; set; }
    }
}