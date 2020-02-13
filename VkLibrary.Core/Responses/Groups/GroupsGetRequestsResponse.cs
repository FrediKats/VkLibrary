using Newtonsoft.Json;

namespace VkApi.Wrapper.Responses.Groups
{
    public class GroupsGetRequestsResponse
    {
        ///<summary>
        /// Total communities number
        ///</summary>
        [JsonProperty("count")]
        public int Count { get; set; }
        [JsonProperty("items")]
        public int[] Items { get; set; }
    }
}