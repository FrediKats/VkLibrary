using Newtonsoft.Json;

namespace VkApi.Wrapper.Responses.Messages
{
    public class MessagesIsMessagesFromGroupAllowedResponse
    {
        [JsonProperty("is_allowed")]
        public int IsAllowed { get; set; }
    }
}