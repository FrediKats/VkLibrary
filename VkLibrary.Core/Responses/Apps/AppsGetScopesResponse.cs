using Newtonsoft.Json;
using VkApi.Wrapper.Types.Apps;

namespace VkApi.Wrapper.Responses.Apps
{
    public class AppsGetScopesResponse
    {
        ///<summary>
        /// Total number
        ///</summary>
        [JsonProperty("count")]
        public int Count { get; set; }
        [JsonProperty("items")]
        public AppsScope[] Items { get; set; }
    }
}