using System;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace VkLib.Types.Base 
{
    public class Likes
    {
        /// <summary>
        /// Likes number
        /// </summary>
        [JsonProperty("count")]
        public int? Count { get; set; }

        /// <summary>
        /// Information whether current user likes the photo
        /// </summary>
        [JsonProperty("user_likes")]
        public int? UserLikes { get; set; }

    }
}
