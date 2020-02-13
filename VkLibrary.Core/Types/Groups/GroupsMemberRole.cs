using Newtonsoft.Json;

namespace VkApi.Wrapper.Types.Groups
{
    public class GroupsMemberRole
    {
        ///<summary>
        /// User ID
        ///</summary>
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("permissions")]
        public GroupsMemberRolePermission[] Permissions { get; set; }
        [JsonProperty("role")]
        public GroupsMemberRoleStatus Role { get; set; }
    }
}