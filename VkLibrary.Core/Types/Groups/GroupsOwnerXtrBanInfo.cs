using Newtonsoft.Json;
using VkApi.Wrapper.Types.Users;

namespace VkApi.Wrapper.Types.Groups
{
    public class GroupsOwnerXtrBanInfo
    {
        [JsonProperty("ban_info")]
        public GroupsBanInfo BanInfo { get; set; }

        ///<summary>
        /// Information about group if type = group
        ///</summary>
        [JsonProperty("group")]
        public GroupsGroup Group { get; set; }

        ///<summary>
        /// Information about group if type = profile
        ///</summary>
        [JsonProperty("profile")]
        public UsersUser Profile { get; set; }
        [JsonProperty("type")]
        public GroupsOwnerXtrBanInfoType Type { get; set; }
    }
}