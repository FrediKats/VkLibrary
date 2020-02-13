using Newtonsoft.Json;
using VkApi.Wrapper.Types.Fave;

namespace VkApi.Wrapper.Responses.Fave
{
    public class FaveGetResponse
    {
        ///<summary>
        /// Total number
        ///</summary>
        [JsonProperty("count")]
        public int Count { get; set; }
        [JsonProperty("items")]
        public FaveBookmark[] Items { get; set; }
    }
}