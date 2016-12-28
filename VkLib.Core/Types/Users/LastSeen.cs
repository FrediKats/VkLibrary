using System;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace VkLib.Types.Users 
{
    public class LastSeen
    {
        /// <summary>
        /// Type of the platform that used for the last authorization
        /// </summary>
        [JsonProperty("platform")]
        public int? Platform { get; set; }

        /// <summary>
        /// Last visit date (in Unix time)
        /// </summary>
        [JsonProperty("time")]
        public double? Time { get; set; }

    }
}
