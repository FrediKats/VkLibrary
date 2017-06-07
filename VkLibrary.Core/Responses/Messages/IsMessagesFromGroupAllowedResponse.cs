using Newtonsoft.Json;

namespace VkLibrary.Core.Responses.Messages
{
    /// <summary>
    /// API IsMessagesFromGroupAllowedResponse.
    /// </summary>
    public class IsMessagesFromGroupAllowedResponse
    {
        /// <summary>
        /// None
        /// </summary>
        [JsonProperty("is_allowed")]
        public int IsAllowed { get; set; }
    }
}