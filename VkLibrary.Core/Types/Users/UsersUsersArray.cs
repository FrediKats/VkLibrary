using Newtonsoft.Json;

namespace VkApi.Wrapper.Types.Users
{
    public class UsersUsersArray
    {
        ///<summary>
        /// Users number
        ///</summary>
        [JsonProperty("count")]
        public int Count { get; set; }
        [JsonProperty("items")]
        public int[] Items { get; set; }
    }
}