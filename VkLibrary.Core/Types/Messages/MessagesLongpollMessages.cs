using Newtonsoft.Json;

namespace VkApi.Wrapper.Types.Messages
{
    public class MessagesLongpollMessages
    {
        ///<summary>
        /// Total number
        ///</summary>
        [JsonProperty("count")]
        public int Count { get; set; }
        [JsonProperty("items")]
        public MessagesMessage[] Items { get; set; }
    }
}