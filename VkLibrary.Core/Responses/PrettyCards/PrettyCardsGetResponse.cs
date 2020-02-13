using Newtonsoft.Json;
using VkApi.Wrapper.Types.PrettyCards;

namespace VkApi.Wrapper.Responses.PrettyCards
{
    public class PrettyCardsGetResponse
    {
        ///<summary>
        /// Total number
        ///</summary>
        [JsonProperty("count")]
        public int Count { get; set; }
        [JsonProperty("items")]
        public PrettyCardsPrettyCard[] Items { get; set; }
    }
}