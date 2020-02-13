using Newtonsoft.Json;

namespace VkApi.Wrapper.Responses.Wall
{
    public class WallEditResponse
    {
        ///<summary>
        /// Edited post ID
        ///</summary>
        [JsonProperty("post_id")]
        public int PostId { get; set; }
    }
}