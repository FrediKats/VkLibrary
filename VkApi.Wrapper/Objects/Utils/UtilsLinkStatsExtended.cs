using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace VkApi.Wrapper.Objects
{
    public class UtilsLinkStatsExtended
    {
        ///<summary>
        /// Link key (characters after vk.cc/)
        ///</summary>
        [JsonProperty("key")]
        public String Key { get; set; }
        [JsonProperty("stats")]
        public UtilsStatsExtended[] Stats { get; set; }
    }
}