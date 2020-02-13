using Newtonsoft.Json;
using VkApi.Wrapper.Types.Database;

namespace VkApi.Wrapper.Responses.Database
{
    public class DatabaseGetFacultiesResponse
    {
        ///<summary>
        /// Total number
        ///</summary>
        [JsonProperty("count")]
        public int Count { get; set; }
        [JsonProperty("items")]
        public DatabaseFaculty[] Items { get; set; }
    }
}