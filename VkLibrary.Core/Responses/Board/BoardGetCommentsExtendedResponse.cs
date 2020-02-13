using Newtonsoft.Json;
using VkApi.Wrapper.Types.Board;
using VkApi.Wrapper.Types.Groups;
using VkApi.Wrapper.Types.Users;

namespace VkApi.Wrapper.Responses.Board
{
    public class BoardGetCommentsExtendedResponse
    {
        ///<summary>
        /// Total number
        ///</summary>
        [JsonProperty("count")]
        public int Count { get; set; }
        [JsonProperty("items")]
        public BoardTopicComment[] Items { get; set; }
        [JsonProperty("poll")]
        public BoardTopicPoll Poll { get; set; }
        [JsonProperty("profiles")]
        public UsersUser[] Profiles { get; set; }
        [JsonProperty("groups")]
        public GroupsGroup[] Groups { get; set; }
    }
}