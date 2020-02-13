using Newtonsoft.Json;

namespace VkApi.Wrapper.Responses.Wall
{
    public class WallPostAdsStealthResponse
    {
        ///<summary>
        /// Created post ID
        ///</summary>
        [JsonProperty("post_id")]
        public int PostId { get; set; }
    }
}