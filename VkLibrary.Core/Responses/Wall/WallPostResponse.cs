using Newtonsoft.Json;

namespace VkApi.Wrapper.Responses.Wall
{
    public class WallPostResponse
    {
        ///<summary>
        /// Created post ID
        ///</summary>
        [JsonProperty("post_id")]
        public int PostId { get; set; }
    }
}