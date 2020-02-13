using Newtonsoft.Json;
using VkApi.Wrapper.Types.Groups;
using VkApi.Wrapper.Types.Users;

namespace VkApi.Wrapper.Responses.Newsfeed
{
    public class NewsfeedGetBannedExtendedResponse
    {
        [JsonProperty("groups")]
        public UsersUserFull[] Groups { get; set; }
        [JsonProperty("profiles")]
        public GroupsGroupFull[] Profiles { get; set; }
    }
}