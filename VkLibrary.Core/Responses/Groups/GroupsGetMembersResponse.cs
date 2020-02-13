using Newtonsoft.Json;

namespace VkApi.Wrapper.Responses.Groups
{
    public class GroupsGetMembersResponse
    {
        ///<summary>
        /// Total members number
        ///</summary>
        [JsonProperty("count")]
        public int Count { get; set; }
        [JsonProperty("items")]
        public int[] Items { get; set; }
    }
}