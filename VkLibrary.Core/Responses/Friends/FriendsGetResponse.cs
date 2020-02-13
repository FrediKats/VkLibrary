using Newtonsoft.Json;

namespace VkApi.Wrapper.Responses.Friends
{
    public class FriendsGetResponse
    {
        ///<summary>
        /// Total friends number
        ///</summary>
        [JsonProperty("count")]
        public int Count { get; set; }
        [JsonProperty("items")]
        public int[] Items { get; set; }
    }
}