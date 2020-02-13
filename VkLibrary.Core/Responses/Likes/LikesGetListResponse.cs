using Newtonsoft.Json;

namespace VkApi.Wrapper.Responses.Likes
{
    public class LikesGetListResponse
    {
        ///<summary>
        /// Total number
        ///</summary>
        [JsonProperty("count")]
        public int Count { get; set; }
        [JsonProperty("items")]
        public int[] Items { get; set; }
    }
}