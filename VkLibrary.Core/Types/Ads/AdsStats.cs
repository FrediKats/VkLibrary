using Newtonsoft.Json;

namespace VkApi.Wrapper.Types.Ads
{
    public class AdsStats
    {
        ///<summary>
        /// Object ID
        ///</summary>
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("stats")]
        public AdsStatsFormat Stats { get; set; }
        [JsonProperty("type")]
        public AdsObjectType Type { get; set; }
    }
}