using System.Collections.Generic;
using Newtonsoft.Json;

namespace VkLibrary.Core.Types.Messages
{
    /// <summary>
    /// API ChatFull object.
    /// </summary>
    public class ChatFull
    {
        /// <summary>
        /// Chat creator ID
        /// </summary>
        [JsonProperty("admin_id")]
        public int? AdminId { get; set; }

        /// <summary>
        /// Property
        /// </summary>
        [JsonProperty("push_settings")]
        public ChatPushSettings PushSettings { get; set; }

        /// <summary>
        /// Shows that user has been left the chat
        /// </summary>
        [JsonProperty("left")]
        public int? Left { get; set; }

        /// <summary>
        /// Chat type
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }

        /// <summary>
        /// URL of the preview image with 100 px in width
        /// </summary>
        [JsonProperty("photo_100")]
        public string Photo100 { get; set; }

        /// <summary>
        /// Shows that user has been kicked from the chat
        /// </summary>
        [JsonProperty("kicked")]
        public int? Kicked { get; set; }

        /// <summary>
        /// Chat ID
        /// </summary>
        [JsonProperty("id")]
        public int? Id { get; set; }

        /// <summary>
        /// URL of the preview image with 50 px in width
        /// </summary>
        [JsonProperty("photo_50")]
        public string Photo50 { get; set; }

        /// <summary>
        /// URL of the preview image with 200 px in width
        /// </summary>
        [JsonProperty("photo_200")]
        public string Photo200 { get; set; }

        /// <summary>
        /// Chat title
        /// </summary>
        [JsonProperty("title")]
        public string Title { get; set; }

        /// <summary>
        /// Property
        /// </summary>
        [JsonProperty("users")]
        public IEnumerable<UserXtrInvitedBy> Users { get; set; }
    }
}