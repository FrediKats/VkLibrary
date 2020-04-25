using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace VkApi.Wrapper.Objects
{
    public class AdsCampaign
    {
        ///<summary>
        /// Campaign's total limit, rubles
        ///</summary>
        [JsonProperty("all_limit")]
        public String AllLimit { get; set; }

        ///<summary>
        /// Campaign's day limit, rubles
        ///</summary>
        [JsonProperty("day_limit")]
        public String DayLimit { get; set; }

        ///<summary>
        /// Campaign ID
        ///</summary>
        [JsonProperty("id")]
        public int Id { get; set; }

        ///<summary>
        /// Campaign title
        ///</summary>
        [JsonProperty("name")]
        public String Name { get; set; }

        ///<summary>
        /// Campaign start time, as Unixtime
        ///</summary>
        [JsonProperty("start_time")]
        public int StartTime { get; set; }
        [JsonProperty("status")]
        public AdsCampaignStatus Status { get; set; }

        ///<summary>
        /// Campaign stop time, as Unixtime
        ///</summary>
        [JsonProperty("stop_time")]
        public int StopTime { get; set; }
        [JsonProperty("type")]
        public AdsCampaignType Type { get; set; }
    }
}