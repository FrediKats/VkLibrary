using Newtonsoft.Json;
using VkApi.Wrapper.Types.Database;

namespace VkApi.Wrapper.Responses.Database
{
    public class DatabaseGetRegionsResponse
    {
        ///<summary>
        /// Total number
        ///</summary>
        [JsonProperty("count")]
        public int Count { get; set; }
        [JsonProperty("items")]
        public DatabaseRegion[] Items { get; set; }
    }
}