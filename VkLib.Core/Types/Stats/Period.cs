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
        [JsonProperty("sex")]
        public IEnumerable<VkLib.Types.Stats.Sex> Sex { get; set; }

        /// <summary>
        /// Total reach
        /// </summary>
        [JsonProperty("reach")]
        public int? Reach { get; set; }

        /// <summary>
        /// Property
        /// </summary>
        [JsonProperty("sex_age")]
        public IEnumerable<VkLib.Types.Stats.SexAge> SexAge { get; set; }

        /// <summary>
        /// Subscribers reach
        /// </summary>
        [JsonProperty("reach_subscribers")]
        public int? ReachSubscribers { get; set; }

        /// <summary>
        /// Day (YYYY-MM-DD)
        /// </summary>
        [JsonProperty("day")]
        public string Day { get; set; }

        /// <summary>
        /// Property
        /// </summary>
        [JsonProperty("countries")]
        public IEnumerable<VkLib.Types.Stats.Country> Countries { get; set; }

        /// <summary>
        /// Visitors number
        /// </summary>
        [JsonProperty("visitors")]
        public int? Visitors { get; set; }

        /// <summary>
        /// Views number
        /// </summary>
        [JsonProperty("views")]
        public int? Views { get; set; }

        /// <summary>
        /// Number of users subscribed
        /// </summary>
        [JsonProperty("subscribed")]
        public int? Subscribed { get; set; }

        /// <summary>
        /// Property
        /// </summary>
        [JsonProperty("cities")]
        public IEnumerable<VkLib.Types.Stats.City> Cities { get; set; }

        /// <summary>
        /// Property
        /// </summary>
        [JsonProperty("age")]
        public IEnumerable<VkLib.Types.Stats.Age> Age { get; set; }

        /// <summary>
        /// Number of users unsubscribed
        /// </summary>
        [JsonProperty("unsubscribed")]
        public int? Unsubscribed { get; set; }

    }
}
