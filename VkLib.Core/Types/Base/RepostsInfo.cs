using System;
using Newtonsoft.Json;

namespace VkLib.Types.Base 
{
    public class RepostsInfo
    {
        /// <summary>
        /// Information whether current user has reposted the post
        /// </summary>
        [JsonProperty("user_reposted")]
        public int? UserReposted { get; set; }

        /// <summary>
        /// Reposts number
        /// </summary>
        [JsonProperty("count")]
        public int? Count { get; set; }

    }
}
