using Newtonsoft.Json;
using VkApi.Wrapper.Types.Groups;

namespace VkApi.Wrapper.Responses.Groups
{
    public class GroupsSearchResponse
    {
        ///<summary>
        /// Total communities number
        ///</summary>
        [JsonProperty("count")]
        public int Count { get; set; }
        [JsonProperty("items")]
        public GroupsGroup[] Items { get; set; }
    }
}