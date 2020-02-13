using Newtonsoft.Json;
using VkApi.Wrapper.Types.Utils;

namespace VkApi.Wrapper.Responses.Utils
{
    public class UtilsGetLastShortenedLinksResponse
    {
        ///<summary>
        /// Total number of available results
        ///</summary>
        [JsonProperty("count")]
        public int Count { get; set; }
        [JsonProperty("items")]
        public UtilsLastShortenedLink[] Items { get; set; }
    }
}