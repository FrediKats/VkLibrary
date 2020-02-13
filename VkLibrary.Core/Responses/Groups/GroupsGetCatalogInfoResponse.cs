using Newtonsoft.Json;
using VkApi.Wrapper.Types.Groups;

namespace VkApi.Wrapper.Responses.Groups
{
    public class GroupsGetCatalogInfoResponse
    {
        ///<summary>
        /// Information whether catalog is enabled for current user
        ///</summary>
        [JsonProperty("enabled")]
        public int Enabled { get; set; }
        [JsonProperty("categories")]
        public GroupsGroupCategory[] Categories { get; set; }
    }
}