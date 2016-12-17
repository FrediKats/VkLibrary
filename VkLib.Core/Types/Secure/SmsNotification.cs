using System;
using Newtonsoft.Json;

namespace VkLib.Types.Secure 
{
    public class SmsNotification
    {
        /// <summary>
        /// Application ID
        /// </summary>
        [JsonProperty("app_id")]
        public int? AppId { get; set; }

        /// <summary>
        /// Notification ID
        /// </summary>
        [JsonProperty("id")]
        public int? Id { get; set; }

        /// <summary>
        /// User ID
        /// </summary>
        [JsonProperty("user_id")]
        public int? UserId { get; set; }

        /// <summary>
        /// Date when message has been sent in Unixtime
        /// </summary>
        [JsonProperty("date")]
        public int? Date { get; set; }

        /// <summary>
        /// Messsage text
        /// </summary>
        [JsonProperty("message")]
        public string Message { get; set; }

    }
}
