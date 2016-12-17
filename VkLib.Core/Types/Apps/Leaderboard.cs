using System;
using Newtonsoft.Json;

namespace VkLib.Types.Apps 
{
    public class Leaderboard
    {
        /// <summary>
        /// User ID
        /// </summary>
        [JsonProperty("user_id")]
        public int? UserId { get; set; }

        /// <summary>
        /// Score number
        /// </summary>
        [JsonProperty("score")]
        public int? Score { get; set; }

        /// <summary>
        /// Points number
        /// </summary>
        [JsonProperty("points")]
        public int? Points { get; set; }

        /// <summary>
        /// Level
        /// </summary>
        [JsonProperty("level")]
        public int? Level { get; set; }

    }
}
