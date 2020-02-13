using Newtonsoft.Json;
using VkApi.Wrapper.Types.Users;

namespace VkApi.Wrapper.Responses.Users
{
    public class UsersSearchResponse
    {
        ///<summary>
        /// Total number of available results
        ///</summary>
        [JsonProperty("count")]
        public int Count { get; set; }
        [JsonProperty("items")]
        public UsersUserFull[] Items { get; set; }
    }
}