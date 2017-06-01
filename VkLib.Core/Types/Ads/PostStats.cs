using Newtonsoft.Json;
using VkLib.Types.Stats;

namespace VkLib.Types.Ads
{
    public class PostStats : WallpostStat
    {
        /// <summary>
        ///     Object ID
        /// </summary>
        [JsonProperty("ad_id")]
        public int? AdId { get; set; }
    }
}