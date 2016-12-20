using System;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace VkLib.Types.Messages 
{
    public class ChatFull
    {
        /// <summary>
        /// Shows that user has been kicked from the chat
        /// </summary>
        [JsonProperty("kicked")]
        public int? Kicked { get; set; }

        /// <summary>
        /// Shows that user has been left the chat
        /// </summary>
        [JsonProperty("left")]
        public int? Left { get; set; }

        /// <summary>
        /// Chat ID
        /// </summary>
        [JsonProperty("id")]
        public int? Id { get; set; }

        /// <summary>
        /// Property
        /// </summary>
        [JsonProperty("push_settings")]
        public VkLib.Types.Messages.ChatPushSettings PushSettings_ { get; set; }

        /// <summary>
        /// URL of the preview image with 100 px in width
        /// </summary>
        [JsonProperty("photo_100")]
        public string Photo100_ { get; set; }

        /// <summary>
        /// Chat creator ID
        /// </summary>
        [JsonProperty("admin_id")]
        public int? AdminId_ { get; set; }

        /// <summary>
        /// URL of the preview image with 50 px in width
        /// </summary>
        [JsonProperty("photo_50")]
        public string Photo50_ { get; set; }

        /// <summary>
        /// Chat type
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }

        /// <summary>
        /// URL of the preview image with 200 px in width
        /// </summary>
        [JsonProperty("photo_200")]
        public string Photo200_ { get; set; }

        /// <summary>
        /// Chat title
        /// </summary>
        [JsonProperty("title")]
        public string Title { get; set; }

        /// <summary>
        /// Property
        /// </summary>
        [JsonProperty("users")]
        public IEnumerable<VkLib.Types.Messages.UserXtrInvitedBy> Users { get; set; }

    }
}
