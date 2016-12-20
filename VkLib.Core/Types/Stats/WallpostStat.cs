using System;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace VkLib.Types.Stats 
{
    public class WallpostStat
    {
        /// <summary>
        /// People have joined the group
        /// </summary>
        [JsonProperty("join_group")]
        public int? JoinGroup_ { get; set; }

        /// <summary>
        /// Link clickthrough
        /// </summary>
        [JsonProperty("links")]
        public int? Links { get; set; }

        /// <summary>
        /// Subscribers reach
        /// </summary>
        [JsonProperty("reach_subscribers")]
        public int? ReachSubscribers_ { get; set; }

        /// <summary>
        /// Hidings number
        /// </summary>
        [JsonProperty("hide")]
        public int? Hide { get; set; }

        /// <summary>
        /// Clickthrough to community
        /// </summary>
        [JsonProperty("to_group")]
        public int? ToGroup_ { get; set; }

        /// <summary>
        /// Total reach
        /// </summary>
        [JsonProperty("reach_total")]
        public int? ReachTotal_ { get; set; }

        /// <summary>
        /// Unsubscribed members
        /// </summary>
        [JsonProperty("unsubscribe")]
        public int? Unsubscribe { get; set; }

        /// <summary>
        /// Reports number
        /// </summary>
        [JsonProperty("report")]
        public int? Report { get; set; }

    }
}
