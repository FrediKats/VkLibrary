using Newtonsoft.Json;
using VkLibrary.Core.Types.Messages;

namespace VkLibrary.Core.Responses.Messages
{
    /// <summary>
    /// API DeleteChatPhotoResponse.
    /// </summary>
    public class DeleteChatPhotoResponse
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