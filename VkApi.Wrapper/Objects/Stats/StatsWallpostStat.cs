using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace VkApi.Wrapper.Objects
{
    public class StatsWallpostStat
    {
        [JsonProperty("post_id")]
        public int PostId { get; set; }

        ///<summary>
        /// Hidings number
        ///</summary>
        [JsonProperty("hide")]
        public int Hide { get; set; }

        ///<summary>
        /// People have joined the group
        ///</summary>
        [JsonProperty("join_group")]
        public int JoinGroup { get; set; }

        ///<summary>
        /// Link clickthrough
        ///</summary>
        [JsonProperty("links")]
        public int Links { get; set; }

        ///<summary>
        /// Subscribers reach
        ///</summary>
        [JsonProperty("reach_subscribers")]
        public int ReachSubscribers { get; set; }
        [JsonProperty("reach_subscribers_count")]
        public int ReachSubscribersCount { get; set; }

        ///<summary>
        /// Total reach
        ///</summary>
        [JsonProperty("reach_total")]
        public int ReachTotal { get; set; }
        [JsonProperty("reach_total_count")]
        public int ReachTotalCount { get; set; }
        [JsonProperty("reach_viral")]
        public int ReachViral { get; set; }
        [JsonProperty("reach_ads")]
        public int ReachAds { get; set; }

        ///<summary>
        /// Reports number
        ///</summary>
        [JsonProperty("report")]
        public int Report { get; set; }

        ///<summary>
        /// Clickthrough to community
        ///</summary>
        [JsonProperty("to_group")]
        public int ToGroup { get; set; }

        ///<summary>
        /// Unsubscribed members
        ///</summary>
        [JsonProperty("unsubscribe")]
        public int Unsubscribe { get; set; }
        [JsonProperty("sex_age")]
        public StatsSexAge[] SexAge { get; set; }
    }
}