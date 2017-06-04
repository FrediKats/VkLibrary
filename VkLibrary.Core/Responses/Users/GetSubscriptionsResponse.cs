using Newtonsoft.Json;
using VkLibrary.Core.Types.Groups;
using VkLibrary.Core.Types.Users;

namespace VkLibrary.Core.Responses.Users
{
    public class GetSubscriptionsResponse
    {
        /// <summary>
        /// None
        /// </summary>
        [JsonProperty("users")]
        public UsersArray Users { get; set; }

        /// <summary>
        /// None
        /// </summary>
        [JsonProperty("groups")]
        public GroupsArray Groups { get; set; }
    }
}