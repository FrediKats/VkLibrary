using Newtonsoft.Json;
using VkApi.Wrapper.Types.Database;

namespace VkApi.Wrapper.Responses.Database
{
    public class DatabaseGetCitiesResponse
    {
        ///<summary>
        /// Total number
        ///</summary>
        [JsonProperty("count")]
        public int Count { get; set; }
        [JsonProperty("items")]
        public DatabaseCity[] Items { get; set; }
    }
}