using Newtonsoft.Json;

namespace VkApi.Wrapper.Responses.Likes
{
    public class LikesDeleteResponse
    {
        ///<summary>
        /// Total likes number
        ///</summary>
        [JsonProperty("likes")]
        public int Likes { get; set; }
    }
}