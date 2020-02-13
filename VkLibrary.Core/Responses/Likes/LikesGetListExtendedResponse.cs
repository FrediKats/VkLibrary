using Newtonsoft.Json;
using VkApi.Wrapper.Types.Users;

namespace VkApi.Wrapper.Responses.Likes
{
    public class LikesGetListExtendedResponse
    {
        ///<summary>
        /// Total number
        ///</summary>
        [JsonProperty("count")]
        public int Count { get; set; }
        [JsonProperty("items")]
        public UsersUserMin[] Items { get; set; }
    }
}