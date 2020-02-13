using System;
using Newtonsoft.Json;

namespace VkApi.Wrapper.Types.Secure
{
    public class SecureSmsNotification
    {
        ///<summary>
        /// Application ID
        ///</summary>
        [JsonProperty("app_id")]
        public String AppId { get; set; }

        ///<summary>
        /// Date when message has been sent in Unixtime
        ///</summary>
        [JsonProperty("date")]
        public String Date { get; set; }

        ///<summary>
        /// Notification ID
        ///</summary>
        [JsonProperty("id")]
        public String Id { get; set; }

        ///<summary>
        /// Messsage text
        ///</summary>
        [JsonProperty("message")]
        public String Message { get; set; }

        ///<summary>
        /// User ID
        ///</summary>
        [JsonProperty("user_id")]
        public String UserId { get; set; }
    }
}