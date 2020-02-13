using Newtonsoft.Json;
using VkApi.Wrapper.Types.Users;

namespace VkApi.Wrapper.Responses.Users
{
    public class UsersGetSubscriptionsExtendedResponse
    {
        ///<summary>
        /// Total number of available results
        ///</summary>
        [JsonProperty("count")]
        public int Count { get; set; }
        [JsonProperty("items")]
        public UsersSubscriptionsItem[] Items { get; set; }
    }
}