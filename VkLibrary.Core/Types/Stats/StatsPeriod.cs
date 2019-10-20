using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace VkLibrary.Core.Objects
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