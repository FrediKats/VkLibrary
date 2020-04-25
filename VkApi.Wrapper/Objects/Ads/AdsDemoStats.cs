using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace VkApi.Wrapper.Objects
{
    public class AdsDemoStats
    {
        ///<summary>
        /// Object ID
        ///</summary>
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("stats")]
        public AdsDemostatsFormat Stats { get; set; }
        [JsonProperty("type")]
        public AdsObjectType Type { get; set; }
    }
}