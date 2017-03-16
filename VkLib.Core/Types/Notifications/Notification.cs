using System;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace VkLib.Types.Notifications 
{
    public class Notification
    {
        /// <summary>
        /// Date when the event has been occured
        /// </summary>
        [JsonProperty("date")]
        public int? Date { get; set; }

        /// <summary>
        /// Property
        /// </summary>
        [JsonProperty("reply")]
        public VkLib.Types.Notifications.Reply Reply { get; set; }

        /// <summary>
        /// Notification type
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }

        /// <summary>
        /// Property
        /// </summary>
        [JsonProperty("feedback")]
        public VkLib.Types.Notifications.Feedback Feedback { get; set; }

        /// <summary>
        /// Property
        /// </summary>
        [JsonProperty("parent")]
        public VkLib.Types.Notifications.Feedback Parent { get; set; }

    }
}
