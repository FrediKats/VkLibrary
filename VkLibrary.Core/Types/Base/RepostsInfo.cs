using Newtonsoft.Json;

namespace VkLibrary.Core.Types.Base
{
    /// <summary>
    /// API RepostsInfo object.
    /// </summary>
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
        public int? UserReposted { get; set; }
    }
}