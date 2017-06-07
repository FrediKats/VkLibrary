using Newtonsoft.Json;
using VkLibrary.Core.Types.Messages;

namespace VkLibrary.Core.Responses.Messages
{
    /// <summary>
    /// API SetChatPhotoResponse.
    /// </summary>
    public class SetChatPhotoResponse
    {
        /// <summary>
        /// None
        /// </summary>
        [JsonProperty("chat")]
        public Chat Chat { get; set; }

        /// <summary>
        /// Service message ID
        /// </summary>
        [JsonProperty("message_id")]
        public int? MessageId { get; set; }
    }
}