using Newtonsoft.Json;
using VkApi.Wrapper.Types.Docs;

namespace VkApi.Wrapper.Responses.Docs
{
    public class DocsSearchResponse
    {
        ///<summary>
        /// Total number
        ///</summary>
        [JsonProperty("count")]
        public int Count { get; set; }
        [JsonProperty("items")]
        public DocsDoc[] Items { get; set; }
    }
}