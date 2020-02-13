using System;
using Newtonsoft.Json;

namespace VkApi.Wrapper.Types.Notifications
{
    public class NotificationsSendMessageError
    {
        ///<summary>
        /// Error code
        ///</summary>
        [JsonProperty("code")]
        public int Code { get; set; }

        ///<summary>
        /// Error description
        ///</summary>
        [JsonProperty("description")]
        public String Description { get; set; }
    }
}