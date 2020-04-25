using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace VkApi.Wrapper.Objects
{
    public class AppsLeaderboard
    {
        ///<summary>
        /// Level
        ///</summary>
        [JsonProperty("level")]
        public int Level { get; set; }

        ///<summary>
        /// Points number
        ///</summary>
        [JsonProperty("points")]
        public int Points { get; set; }

        ///<summary>
        /// Score number
        ///</summary>
        [JsonProperty("score")]
        public int Score { get; set; }

        ///<summary>
        /// User ID
        ///</summary>
        [JsonProperty("user_id")]
        public int UserId { get; set; }
    }
}