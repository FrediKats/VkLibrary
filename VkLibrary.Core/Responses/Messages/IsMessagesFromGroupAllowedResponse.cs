using Newtonsoft.Json;

namespace VkLibrary.Core.Responses.Messages
{
    public class IsMessagesFromGroupAllowedResponse
    {
        /// <summary>
        /// None
        /// </summary>
        [JsonProperty("is_allowed")]
        public int IsAllowed { get; set; }
    }
}