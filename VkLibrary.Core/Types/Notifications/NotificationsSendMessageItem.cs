using System;
using Newtonsoft.Json;

namespace VkApi.Wrapper.Types.Notifications
{
    public class NotificationsSendMessageItem
    {
        ///<summary>
        /// User ID
        ///</summary>
        [JsonProperty("user_id")]
        public int UserId { get; set; }

        ///<summary>
        /// Notification status
        ///</summary>
        [JsonProperty("status")]
        public Boolean Status { get; set; }
        [JsonProperty("error")]
        public NotificationsSendMessageError Error { get; set; }
    }
}