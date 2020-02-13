using System;
using Newtonsoft.Json;

namespace VkApi.Wrapper.Types.Utils
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