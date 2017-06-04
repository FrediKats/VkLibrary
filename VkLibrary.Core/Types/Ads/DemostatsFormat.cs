using System.Collections.Generic;
using Newtonsoft.Json;

namespace VkLibrary.Core.Types.Ads
{
    public class DemostatsFormat
    {
        /// <summary>
        /// Property
        /// </summary>
        [JsonProperty("sex")]
        public IEnumerable<StatsSex> Sex { get; set; }

        /// <summary>
        /// 1 if period=overall
        /// </summary>
        [JsonProperty("overall")]
        public int? Overall { get; set; }

        /// <summary>
        /// Property
        /// </summary>
        [JsonProperty("sex_age")]
        public IEnumerable<StatsSexAge> SexAge { get; set; }

        /// <summary>
        /// Property
        /// </summary>
        [JsonProperty("cities")]
        public IEnumerable<StatsCities> Cities { get; set; }

        /// <summary>
        /// Property
        /// </summary>
        [JsonProperty("age")]
        public IEnumerable<StatsAge> Age { get; set; }

        /// <summary>
        /// Day as YYYY-MM-DD
        /// </summary>
        [JsonProperty("day")]
        public string Day { get; set; }

        /// <summary>
        /// Month as YYYY-MM
        /// </summary>
        [JsonProperty("month")]
        public string Month { get; set; }
    }
}