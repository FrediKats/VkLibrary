using Newtonsoft.Json;
using VkApi.Wrapper.Types.Groups;

namespace VkApi.Wrapper.Responses.Groups
{
    public class GroupsGetBannedResponse
    {
        ///<summary>
        /// Total users number
        ///</summary>
        [JsonProperty("count")]
        public int Count { get; set; }
        [JsonProperty("items")]
        public GroupsBannedItem[] Items { get; set; }
    }
}