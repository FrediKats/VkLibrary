using Newtonsoft.Json;
using VkApi.Wrapper.Types.Apps;

namespace VkApi.Wrapper.Responses.Apps
{
    public class AppsGetCatalogResponse
    {
        ///<summary>
        /// Total number
        ///</summary>
        [JsonProperty("count")]
        public int Count { get; set; }
        [JsonProperty("items")]
        public AppsApp[] Items { get; set; }
    }
}