using Newtonsoft.Json;
using VkApi.Wrapper.Types.Groups;

namespace VkApi.Wrapper.Responses.Groups
{
    public class GroupsGetExtendedResponse
    {
        ///<summary>
        /// Total communities number
        ///</summary>
        [JsonProperty("count")]
        public int Count { get; set; }
        [JsonProperty("items")]
        public GroupsGroupFull[] Items { get; set; }
    }
}