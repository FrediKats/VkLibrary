using Newtonsoft.Json;
using VkApi.Wrapper.Types.Groups;

namespace VkApi.Wrapper.Responses.Groups
{
    public class GroupsGetMembersFieldsResponse
    {
        ///<summary>
        /// Total members number
        ///</summary>
        [JsonProperty("count")]
        public int Count { get; set; }
        [JsonProperty("items")]
        public GroupsUserXtrRole[] Items { get; set; }
    }
}