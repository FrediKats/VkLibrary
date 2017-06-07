using Newtonsoft.Json;

namespace VkLibrary.Core.Types.Secure
{
    /// <summary>
    /// API SmsNotification object.
    /// </summary>
    public class SmsNotification
    {
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
        /// Messsage text
        /// </summary>
        [JsonProperty("message")]
        public string Message { get; set; }
    }
}