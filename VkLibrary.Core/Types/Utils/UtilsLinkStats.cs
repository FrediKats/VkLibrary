using System;
using Newtonsoft.Json;

namespace VkApi.Wrapper.Types.Utils
{
    public class UtilsLinkStats
    {
        ///<summary>
        /// Link key (characters after vk.cc/)
        ///</summary>
        [JsonProperty("key")]
        public String Key { get; set; }
        [JsonProperty("stats")]
        public UtilsStats[] Stats { get; set; }
    }
}