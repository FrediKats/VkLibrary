using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace VkApi.Wrapper.Objects
{
    public class LeadsLeadDays
    {
        ///<summary>
        /// Completed offers number
        ///</summary>
        [JsonProperty("completed")]
        public int Completed { get; set; }

        ///<summary>
        /// Impressions number
        ///</summary>
        [JsonProperty("impressions")]
        public int Impressions { get; set; }

        ///<summary>
        /// Amount of spent votes
        ///</summary>
        [JsonProperty("spent")]
        public int Spent { get; set; }

        ///<summary>
        /// Started offers number
        ///</summary>
        [JsonProperty("started")]
        public int Started { get; set; }
    }
}