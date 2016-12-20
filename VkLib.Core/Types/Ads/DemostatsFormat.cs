using System;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace VkLib.Types.Ads 
{
    public class DemostatsFormat
    {
        /// <summary>
        /// Property
        /// </summary>
        [JsonProperty("age")]
        public IEnumerable<VkLib.Types.Ads.StatsAge> Age { get; set; }

        /// <summary>
        /// Month as YYYY-MM
        /// </summary>
        [JsonProperty("month")]
        public string Month { get; set; }

        /// <summary>
        /// Property
        /// </summary>
        [JsonProperty("sex")]
        public IEnumerable<VkLib.Types.Ads.StatsSex> Sex { get; set; }

        /// <summary>
        /// Property
        /// </summary>
        [JsonProperty("sex_age")]
        public IEnumerable<VkLib.Types.Ads.StatsSexAge> SexAge_ { get; set; }

        /// <summary>
        /// Day as YYYY-MM-DD
        /// </summary>
        [JsonProperty("day")]
        public string Day { get; set; }

        /// <summary>
        /// Property
        /// </summary>
        [JsonProperty("cities")]
        public IEnumerable<VkLib.Types.Ads.StatsCities> Cities { get; set; }

        /// <summary>
        /// 1 if period=overall
        /// </summary>
        [JsonProperty("overall")]
        public int? Overall { get; set; }

    }
}
