using Newtonsoft.Json;

namespace VkLibrary.Core.Responses.Likes
{
    /// <summary>
    /// API IsLikedResponse.
    /// </summary>
    public class IsLikedResponse
    {
        /// <summary>
        /// Information whether user reposted the object
        /// </summary>
        [JsonProperty("copied")]
        public int Copied { get; set; }

        /// <summary>
        /// Information whether user liked the object
        /// </summary>
        [JsonProperty("liked")]
        public int Liked { get; set; }
    }
}