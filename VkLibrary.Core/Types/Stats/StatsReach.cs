using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace VkLibrary.Core.Objects
{
    ///<summary>
    /// Reach stats
    ///</summary>
    public class StatsReach
    {
        [JsonProperty("age")]
        public StatsSexAge[] Age { get; set; }
        [JsonProperty("cities")]
        public StatsCity[] Cities { get; set; }
        [JsonProperty("countries")]
        public StatsCountry[] Countries { get; set; }

        ///<summary>
        /// Reach count from mobile devices
        ///</summary>
        [JsonProperty("mobile_reach")]
        public int MobileReach { get; set; }

        ///<summary>
        /// Reach count
        ///</summary>
        [JsonProperty("reach")]
        public int Reach { get; set; }

        ///<summary>
        /// Subscribers reach count
        ///</summary>
        [JsonProperty("reach_subscribers")]
        public int ReachSubscribers { get; set; }
        [JsonProperty("sex")]
        public StatsSexAge[] Sex { get; set; }
        [JsonProperty("sex_age")]
        public StatsSexAge[] SexAge { get; set; }
    }
}