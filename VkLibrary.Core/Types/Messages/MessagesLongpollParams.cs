using System;
using Newtonsoft.Json;

namespace VkApi.Wrapper.Types.Messages
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