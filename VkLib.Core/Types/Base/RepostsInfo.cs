using System;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace VkLib.Types.Base 
{
    public class RepostsInfo
    {
        /// <summary>
        /// Reposts number
        /// </summary>
        [JsonProperty("count")]
        public int? Count { get; set; }

        /// <summary>
        /// Information whether current user has reposted the post
        /// </summary>
        [JsonProperty("user_reposted")]
        public int? UserReposted_ { get; set; }

    }
}
