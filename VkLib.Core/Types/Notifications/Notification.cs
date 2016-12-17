using System;
using Newtonsoft.Json;

namespace VkLib.Types.Notifications 
{
    public class Notification
    {
        /// <summary>
        /// Notification type
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }

        /// <summary>
        /// Property
        /// </summary>
        [JsonProperty("parent")]
        public IEnumerable<object> Parent { get; set; }

        /// <summary>
        /// Property
        /// </summary>
        [JsonProperty("feedback")]
        public Feedback Feedback { get; set; }

        /// <summary>
        /// Property
        /// </summary>
        [JsonProperty("reply")]
        public Reply Reply { get; set; }

        /// <summary>
        /// Date when the event has been occured
        /// </summary>
        [JsonProperty("date")]
        public int? Date { get; set; }

    }
}
