using Newtonsoft.Json;

namespace VkApi.Wrapper.Types.Ads
{
    public class AdsFloodStats
    {
        ///<summary>
        /// Requests left
        ///</summary>
        [JsonProperty("left")]
        public int Left { get; set; }

        ///<summary>
        /// Time to refresh in seconds
        ///</summary>
        [JsonProperty("refresh")]
        public int Refresh { get; set; }
    }
}