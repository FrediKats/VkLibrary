using Newtonsoft.Json;

namespace VkApi.Wrapper.Types.Groups
{
    public class GroupsUserXtrRole
    {
        [JsonProperty("role")]
        public GroupsRoleOptions Role { get; set; }
    }
}