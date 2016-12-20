using System;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace VkLib.Types.Apps 
{
    public class Leaderboard
    {
        /// <summary>
        /// Score number
        /// </summary>
        [JsonProperty("score")]
        public int? Score_ { get; set; }

        /// <summary>
        /// User ID
        /// </summary>
        [JsonProperty("user_id")]
        public int? UserId { get; set; }

        /// <summary>
        /// Level
        /// </summary>
        [JsonProperty("level")]
        public int? Level_ { get; set; }

        /// <summary>
        /// Points number
        /// </summary>
        [JsonProperty("points")]
        public int? Points_ { get; set; }

    }
}
