using Newtonsoft.Json;

namespace VkLib.Responses.Messages
{
    public class IsMessagesFromGroupAllowedResponse
    {
        /// <summary>
        ///     None
        /// </summary>
        [JsonProperty("is_allowed")]
        public int IsAllowed { get; set; }
    }
}