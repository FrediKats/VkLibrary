using Newtonsoft.Json;
using VkApi.Wrapper.Types.Groups;
using VkApi.Wrapper.Types.Users;

namespace VkApi.Wrapper.Responses.Users
{
    public class UsersGetSubscriptionsResponse
    {
        [JsonProperty("users")]
        public UsersUsersArray Users { get; set; }
        [JsonProperty("groups")]
        public GroupsGroupsArray Groups { get; set; }
    }
}