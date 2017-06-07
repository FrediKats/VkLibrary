using Newtonsoft.Json;

namespace VkLibrary.Core.Types.Messages
{
    /// <summary>
    /// API Dialog object.
    /// </summary>
    public class Dialog
    {
        /// <summary>
        /// ID of the last message read by the others
        /// </summary>
        [JsonProperty("out_read")]
        public int? OutRead { get; set; }

        /// <summary>
        /// Information whether unread messages are in the dialog
        /// </summary>
        [JsonProperty("unread")]
        public int? Unread { get; set; }

        /// <summary>
        /// ID of the last message read by current user
        /// </summary>
        [JsonProperty("in_read")]
        public int? InRead { get; set; }

        /// <summary>
        /// Property
        /// </summary>
        [JsonProperty("message")]
        public Message Message { get; set; }
    }
}