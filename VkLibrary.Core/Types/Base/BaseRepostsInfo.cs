using Newtonsoft.Json;

namespace VkApi.Wrapper.Types.Base
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