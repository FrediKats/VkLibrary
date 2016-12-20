using System;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace VkLib.Types.Stats 
{
    public class Period
    {
        /// <summary>
        /// Property
        /// </summary>
        [JsonProperty("age")]
        public IEnumerable<VkLib.Types.Stats.Age> Age_ { get; set; }

        /// <summary>
        /// Number of users subscribed
        /// </summary>
        [JsonProperty("subscribed")]
        public int? Subscribed_ { get; set; }

        /// <summary>
        /// Visitors number
        /// </summary>
        [JsonProperty("visitors")]
        public int? Visitors_ { get; set; }

        /// <summary>
        /// Day (YYYY-MM-DD)
        /// </summary>
        [JsonProperty("day")]
        public string Day_ { get; set; }

        /// <summary>
        /// Property
        /// </summary>
        [JsonProperty("cities")]
        public IEnumerable<VkLib.Types.Stats.City> Cities_ { get; set; }

        /// <summary>
        /// Views number
        /// </summary>
        [JsonProperty("views")]
        public int? Views_ { get; set; }

        /// <summary>
        /// Property
        /// </summary>
        [JsonProperty("sex")]
        public IEnumerable<VkLib.Types.Stats.Sex> Sex_ { get; set; }

        /// <summary>
        /// Property
        /// </summary>
        [JsonProperty("sex_age")]
        public IEnumerable<VkLib.Types.Stats.SexAge> SexAge { get; set; }

        /// <summary>
        /// Property
        /// </summary>
        [JsonProperty("countries")]
        public IEnumerable<VkLib.Types.Stats.Country> Countries_ { get; set; }

        /// <summary>
        /// Subscribers reach
        /// </summary>
        [JsonProperty("reach_subscribers")]
        public int? ReachSubscribers { get; set; }

        /// <summary>
        /// Number of users unsubscribed
        /// </summary>
        [JsonProperty("unsubscribed")]
        public int? Unsubscribed_ { get; set; }

        /// <summary>
        /// Total reach
        /// </summary>
        [JsonProperty("reach")]
        public int? Reach_ { get; set; }

    }
}
