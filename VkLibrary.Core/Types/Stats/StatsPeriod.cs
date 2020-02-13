using Newtonsoft.Json;

namespace VkApi.Wrapper.Types.Stats
{
    public class StatsPeriod
    {
        [JsonProperty("activity")]
        public StatsActivity Activity { get; set; }

        ///<summary>
        /// Unix timestamp
        ///</summary>
        [JsonProperty("period_from")]
        public int PeriodFrom { get; set; }

        ///<summary>
        /// Unix timestamp
        ///</summary>
        [JsonProperty("period_to")]
        public int PeriodTo { get; set; }
        [JsonProperty("reach")]
        public StatsReach Reach { get; set; }
        [JsonProperty("visitors")]
        public StatsViews Visitors { get; set; }
    }
}