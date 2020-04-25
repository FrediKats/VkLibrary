using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace VkApi.Wrapper.Objects
{
    public class NotificationsReply
    {
        ///<summary>
        /// Date when the reply has been created in Unixtime
        ///</summary>
        [JsonProperty("date")]
        public int Date { get; set; }

        ///<summary>
        /// Reply ID
        ///</summary>
        [JsonProperty("id")]
        public int Id { get; set; }

        ///<summary>
        /// Reply text
        ///</summary>
        [JsonProperty("text")]
        public int Text { get; set; }
    }
}