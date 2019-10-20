using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace VkLibrary.Core.Objects
{
    public class GroupsLongPollServer
    {
        ///<summary>
        /// Long Poll key
        ///</summary>
        [JsonProperty("key")]
        public String Key { get; set; }

        ///<summary>
        /// Long Poll server address
        ///</summary>
        [JsonProperty("server")]
        public String Server { get; set; }

        ///<summary>
        /// Number of the last event
        ///</summary>
        [JsonProperty("ts")]
        public String Ts { get; set; }
    }
}