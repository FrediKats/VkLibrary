using Newtonsoft.Json;

namespace VkApi.Wrapper.Types.Base
{
    public class BaseLikes
    {
        ///<summary>
        /// Likes number
        ///</summary>
        [JsonProperty("count")]
        public int Count { get; set; }

        ///<summary>
        /// Information whether current user likes the photo
        ///</summary>
        [JsonProperty("user_likes")]
        public int UserLikes { get; set; }
    }
}