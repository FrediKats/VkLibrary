using Newtonsoft.Json;
using VkApi.Wrapper.Types.Users;

namespace VkApi.Wrapper.Responses.Stories
{
    public class StoriesGetViewersExtendedResponse
    {
        ///<summary>
        /// Viewers count
        ///</summary>
        [JsonProperty("count")]
        public int Count { get; set; }
        [JsonProperty("items")]
        public UsersUserFull[] Items { get; set; }
    }
}