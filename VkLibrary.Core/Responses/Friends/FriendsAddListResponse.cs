using Newtonsoft.Json;

namespace VkApi.Wrapper.Responses.Friends
{
    public class FriendsAddListResponse
    {
        ///<summary>
        /// List ID
        ///</summary>
        [JsonProperty("list_id")]
        public int ListId { get; set; }
    }
}