using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace VkLibrary.Core.Objects
{
    public class BaseRepostsInfo
    {
        ///<summary>
        /// Reposts number
        ///</summary>
        [JsonProperty("count")]
        public int Count { get; set; }

        ///<summary>
        /// Information whether current user has reposted the post
        ///</summary>
        [JsonProperty("user_reposted")]
        public int UserReposted { get; set; }
    }
}