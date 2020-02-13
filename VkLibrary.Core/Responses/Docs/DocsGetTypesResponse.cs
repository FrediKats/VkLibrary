using Newtonsoft.Json;
using VkApi.Wrapper.Types.Docs;

namespace VkApi.Wrapper.Responses.Docs
{
    public class DocsGetTypesResponse
    {
        ///<summary>
        /// Total number
        ///</summary>
        [JsonProperty("count")]
        public int Count { get; set; }
        [JsonProperty("items")]
        public DocsDocTypes[] Items { get; set; }
    }
}