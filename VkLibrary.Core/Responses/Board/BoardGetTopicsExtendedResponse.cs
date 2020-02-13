using Newtonsoft.Json;
using VkApi.Wrapper.Types.Board;
using VkApi.Wrapper.Types.Users;

namespace VkApi.Wrapper.Responses.Board
{
    public class BoardGetTopicsExtendedResponse
    {
        ///<summary>
        /// Total number
        ///</summary>
        [JsonProperty("count")]
        public int Count { get; set; }
        [JsonProperty("items")]
        public BoardTopic[] Items { get; set; }
        [JsonProperty("default_order")]
        public BoardDefaultOrder DefaultOrder { get; set; }

        ///<summary>
        /// Information whether current user can add topic
        ///</summary>
        [JsonProperty("can_add_topics")]
        public int CanAddTopics { get; set; }
        [JsonProperty("profiles")]
        public UsersUserMin[] Profiles { get; set; }
    }
}