using Newtonsoft.Json;
using VkLib.Types.Messages;

namespace VkLib.Responses.Messages
{
    public class SetChatPhotoResponse
    {
        /// <summary>
        ///     None
        /// </summary>
        [JsonProperty("chat")]
        public Chat Chat { get; set; }

        /// <summary>
        ///     Service message ID
        /// </summary>
        [JsonProperty("message_id")]
        public int? MessageId { get; set; }
    }
}