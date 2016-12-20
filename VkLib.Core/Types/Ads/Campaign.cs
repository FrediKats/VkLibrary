using System;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace VkLib.Types.Ads 
{
    public class Campaign
    {
        /// <summary>
        /// Campaign title
        /// </summary>
        [JsonProperty("name")]
        public int? Name_ { get; set; }

        /// <summary>
        /// Campaign ID
        /// </summary>
        [JsonProperty("id")]
        public int? Id_ { get; set; }

        /// <summary>
        /// Campaign's total limit, rubles
        /// </summary>
        [JsonProperty("all_limit")]
        public string AllLimit { get; set; }

        /// <summary>
        /// Campaign stop time, as Unixtime
        /// </summary>
        [JsonProperty("stop_time")]
        public int? StopTime { get; set; }

        /// <summary>
        /// Campaign start time, as Unixtime
        /// </summary>
        [JsonProperty("start_time")]
        public int? StartTime { get; set; }

        /// <summary>
        /// Campaign type
        /// </summary>
        [JsonProperty("type")]
        public string Type_ { get; set; }

        /// <summary>
        /// Campaign's day limit, rubles
        /// </summary>
        [JsonProperty("day_limit")]
        public string DayLimit { get; set; }

        /// <summary>
        /// Campaign status
        /// </summary>
        [JsonProperty("status")]
        public int? Status_ { get; set; }

    }
}
