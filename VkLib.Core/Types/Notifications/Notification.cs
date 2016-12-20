using System;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace VkLib.Types.Notifications 
{
    public class Notification
    {
        /// <summary>
        /// Notification type
        /// </summary>
        [JsonProperty("type")]
        public string Type_ { get; set; }

        /// <summary>
        /// Property
        /// </summary>
        [JsonProperty("feedback")]
        public VkLib.Types.Notifications.Feedback Feedback_ { get; set; }

        /// <summary>
        /// Property
        /// </summary>
        [JsonProperty("parent")]
        public IEnumerable<object> Parent_ { get; set; }

        /// <summary>
        /// Date when the event has been occured
        /// </summary>
        [JsonProperty("date")]
        public int? Date_ { get; set; }

        /// <summary>
        /// Property
        /// </summary>
        [JsonProperty("reply")]
        public VkLib.Types.Notifications.Reply Reply_ { get; set; }

    }
}
