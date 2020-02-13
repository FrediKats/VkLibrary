using Newtonsoft.Json;
using VkApi.Wrapper.Types.Wall;

namespace VkApi.Wrapper.Responses.Newsfeed
{
    public class NewsfeedGetMentionsResponse
    {
        ///<summary>
        /// Total number
        ///</summary>
        [JsonProperty("count")]
        public int Count { get; set; }
        [JsonProperty("items")]
        public WallWallpostToId[] Items { get; set; }
    }
}