using Newtonsoft.Json;
using VkApi.Wrapper.Types.Groups;

namespace VkApi.Wrapper.Responses.Groups
{
    public class GroupsGetTokenPermissionsResponse
    {
        [JsonProperty("mask")]
        public int Mask { get; set; }
        [JsonProperty("permissions")]
        public GroupsTokenPermissionSetting[] Permissions { get; set; }
    }
}