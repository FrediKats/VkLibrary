using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace VkApi.Wrapper.Objects
{
    public class MessagesGraffiti
    {
        ///<summary>
        /// Access key for graffiti
        ///</summary>
        [JsonProperty("access_key")]
        public String AccessKey { get; set; }

        ///<summary>
        /// Graffiti height
        ///</summary>
        [JsonProperty("height")]
        public int Height { get; set; }

        ///<summary>
        /// Graffiti ID
        ///</summary>
        [JsonProperty("id")]
        public int Id { get; set; }

        ///<summary>
        /// Graffiti owner ID
        ///</summary>
        [JsonProperty("owner_id")]
        public int OwnerId { get; set; }

        ///<summary>
        /// Graffiti URL
        ///</summary>
        [JsonProperty("url")]
        public String Url { get; set; }

        ///<summary>
        /// Graffiti width
        ///</summary>
        [JsonProperty("width")]
        public int Width { get; set; }
    }
}