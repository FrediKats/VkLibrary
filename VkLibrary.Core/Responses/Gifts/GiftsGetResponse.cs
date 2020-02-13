using Newtonsoft.Json;
using VkApi.Wrapper.Types.Gifts;

namespace VkApi.Wrapper.Responses.Gifts
{
    public class GiftsGetResponse
    {
        ///<summary>
        /// Total number
        ///</summary>
        [JsonProperty("count")]
        public int Count { get; set; }
        [JsonProperty("items")]
        public GiftsGift[] Items { get; set; }
    }
}