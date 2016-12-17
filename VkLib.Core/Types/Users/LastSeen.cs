using System;
using Newtonsoft.Json;

namespace VkLib.Types.Users 
{
    public class LastSeen
    {
        /// <summary>
        /// Last visit date (in Unix time)
        /// </summary>
        [JsonProperty("time")]
        public int? Time { get; set; }

        /// <summary>
        /// Type of the platform that used for the last authorization
        /// </summary>
        [JsonProperty("platform")]
        public int? Platform { get; set; }

    }
}
