using Newtonsoft.Json;
using VkLib.Types.Groups;
using VkLib.Types.Users;

namespace VkLib.Responses.Users
{
    public class GetSubscriptionsResponse
    {
        /// <summary>
        ///     None
        /// </summary>
        [JsonProperty("users")]
        public UsersArray Users { get; set; }

        /// <summary>
        ///     None
        /// </summary>
        [JsonProperty("groups")]
        public GroupsArray Groups { get; set; }
    }
}