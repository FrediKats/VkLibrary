using Newtonsoft.Json;
using VkApi.Wrapper.Types.Base;

namespace VkApi.Wrapper.Responses.Database
{
    public class DatabaseGetCountriesResponse
    {
        ///<summary>
        /// Total number
        ///</summary>
        [JsonProperty("count")]
        public int Count { get; set; }
        [JsonProperty("items")]
        public BaseCountry[] Items { get; set; }
    }
}