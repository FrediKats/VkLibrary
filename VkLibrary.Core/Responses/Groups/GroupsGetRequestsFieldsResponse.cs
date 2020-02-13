using Newtonsoft.Json;
using VkApi.Wrapper.Types.Users;

namespace VkApi.Wrapper.Responses.Groups
{
    public class GroupsGetRequestsFieldsResponse
    {
        ///<summary>
        /// Total communities number
        ///</summary>
        [JsonProperty("count")]
        public int Count { get; set; }
        [JsonProperty("items")]
        public UsersUserFull[] Items { get; set; }
    }
}