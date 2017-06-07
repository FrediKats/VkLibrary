using Newtonsoft.Json;

namespace VkLibrary.Core.Types.Messages
{
    /// <summary>
    /// API AttachmentsContainer object.
    /// </summary>
    public class AttachmentsContainer
    {
        /// <summary>
        /// Message id
        /// </summary>
        [JsonProperty("message_id")]
        public string MessageId { get; set; }

        /// <summary>
        /// Message id
        /// </summary>
        [JsonProperty("attachment")]
        public AttachmentsHistory Attachment { get; set; }
    }
}