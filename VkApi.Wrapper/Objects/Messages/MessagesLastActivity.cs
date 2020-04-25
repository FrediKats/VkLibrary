using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace VkApi.Wrapper.Objects
{
    public class MessagesLastActivity
    {
        ///<summary>
        /// Information whether user is online
        ///</summary>
        [JsonProperty("online")]
        public int Online { get; set; }

        ///<summary>
        /// Time when user was online in Unixtime
        ///</summary>
        [JsonProperty("time")]
        public int Time { get; set; }
    }
}