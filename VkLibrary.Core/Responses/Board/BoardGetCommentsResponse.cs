using Newtonsoft.Json;
using VkApi.Wrapper.Types.Board;

namespace VkApi.Wrapper.Responses.Board
{
    public class BoardGetCommentsResponse
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
    }
}