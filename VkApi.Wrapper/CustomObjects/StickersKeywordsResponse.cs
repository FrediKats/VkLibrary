using Newtonsoft.Json;

namespace VkApi.Wrapper.CustomObjects
{
    public class StickersKeywordsResponse
    {
        ///<summary>
        /// Total number
        ///</summary>
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("dictionary")]
        public StickersKeywords[] Dictionary { get; set; }
    }
}