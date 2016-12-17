using System;
using Newtonsoft.Json;

namespace VkLib.Types.Messages 
{
    public class LongpollParams
    {
        /// <summary>
        /// Key
        /// </summary>
        [JsonProperty("key")]
        public string Key { get; set; }

        /// <summary>
        /// Timestamp
        /// </summary>
        [JsonProperty("ts")]
        public int? Ts { get; set; }

        /// <summary>
        /// Server URL
        /// </summary>
        [JsonProperty("server")]
        public string Server { get; set; }

    }
}
