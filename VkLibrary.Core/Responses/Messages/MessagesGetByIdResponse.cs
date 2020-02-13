using Newtonsoft.Json;
using VkApi.Wrapper.Types.Messages;

namespace VkApi.Wrapper.Responses.Messages
{
    public class MessagesGetByIdResponse
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