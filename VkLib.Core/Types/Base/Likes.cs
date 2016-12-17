using System;
using Newtonsoft.Json;

namespace VkLib.Types.Base 
{
    public class Likes
    {
        /// <summary>
        /// Information whether current user likes the photo
        /// </summary>
        [JsonProperty("user_likes")]
        public BoolInt UserLikes { get; set; }

        /// <summary>
        /// Likes number
        /// </summary>
        [JsonProperty("count")]
        public int? Count { get; set; }

    }
}
