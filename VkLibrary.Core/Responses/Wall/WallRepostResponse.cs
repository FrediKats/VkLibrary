using Newtonsoft.Json;
using VkApi.Wrapper.Types.Base;

namespace VkApi.Wrapper.Responses.Wall
{
    public class WallRepostResponse
    {
        [JsonProperty("success")]
        public BaseOkResponse Success { get; set; }

        ///<summary>
        /// Created post ID
        ///</summary>
        [JsonProperty("post_id")]
        public int PostId { get; set; }

        ///<summary>
        /// Reposts number
        ///</summary>
        [JsonProperty("reposts_count")]
        public int RepostsCount { get; set; }

        ///<summary>
        /// Reposts number
        ///</summary>
        [JsonProperty("likes_count")]
        public int LikesCount { get; set; }
    }
}