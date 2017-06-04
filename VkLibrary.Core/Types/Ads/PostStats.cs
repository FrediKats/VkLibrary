using Newtonsoft.Json;
using VkLibrary.Core.Types.Stats;

namespace VkLibrary.Core.Types.Ads
{
    public class PostStats : WallpostStat
    {
        /// <summary>
        /// Object ID
        /// </summary>
        [JsonProperty("ad_id")]
        public int? AdId { get; set; }
    }
}