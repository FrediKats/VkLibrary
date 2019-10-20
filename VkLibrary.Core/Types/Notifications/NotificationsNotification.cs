using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace VkLibrary.Core.Objects
{
    public class NotificationsNotification
    {
        ///<summary>
        /// Date when the event has been occurred
        ///</summary>
        [JsonProperty("date")]
        public int Date { get; set; }
        [JsonProperty("feedback")]
        public NotificationsFeedback Feedback { get; set; }
        [JsonProperty("parent")]
        public NotificationsNotificationParent Parent { get; set; }
        [JsonProperty("reply")]
        public NotificationsReply Reply { get; set; }

        ///<summary>
        /// Notification type
        ///</summary>
        [JsonProperty("type")]
        public String Type { get; set; }
    }
}