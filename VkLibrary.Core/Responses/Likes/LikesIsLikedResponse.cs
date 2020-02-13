using Newtonsoft.Json;

namespace VkApi.Wrapper.Responses.Likes
{
    public class LikesIsLikedResponse
    {
        ///<summary>
        /// Information whether user liked the object
        ///</summary>
        [JsonProperty("liked")]
        public int Liked { get; set; }

        ///<summary>
        /// Information whether user reposted the object
        ///</summary>
        [JsonProperty("copied")]
        public int Copied { get; set; }
    }
}