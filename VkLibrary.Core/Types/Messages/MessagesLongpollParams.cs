using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace VkLibrary.Core.Objects
{
    public class MessagesLongpollParams
    {
        ///<summary>
        /// Key
        ///</summary>
        [JsonProperty("key")]
        public String Key { get; set; }

        ///<summary>
        /// Persistent timestamp
        ///</summary>
        [JsonProperty("pts")]
        public int Pts { get; set; }

        ///<summary>
        /// Server URL
        ///</summary>
        [JsonProperty("server")]
        public String Server { get; set; }

        ///<summary>
        /// Timestamp
        ///</summary>
        [JsonProperty("ts")]
        public int Ts { get; set; }
    }
}