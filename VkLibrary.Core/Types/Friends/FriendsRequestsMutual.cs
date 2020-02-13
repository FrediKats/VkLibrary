using Newtonsoft.Json;

namespace VkApi.Wrapper.Types.Friends
{
    public class FriendsRequestsMutual
    {
        ///<summary>
        /// Total mutual friends number
        ///</summary>
        [JsonProperty("count")]
        public int Count { get; set; }
        [JsonProperty("users")]
        public int[] Users { get; set; }
    }
}