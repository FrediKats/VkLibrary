using System;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace VkLib.Types.Audio 
{
    public class Audio
    {
        /// <summary>
        /// Artist name
        /// </summary>
        [JsonProperty("artist")]
        public string Artist_ { get; set; }

        /// <summary>
        /// Audio ID
        /// </summary>
        [JsonProperty("id")]
        public int? Id_ { get; set; }

        /// <summary>
        /// Audio owner's ID
        /// </summary>
        [JsonProperty("owner_id")]
        public int? OwnerId { get; set; }

        /// <summary>
        /// URL of mp3 file
        /// </summary>
        [JsonProperty("url")]
        public string Url_ { get; set; }

        /// <summary>
        /// Title
        /// </summary>
        [JsonProperty("title")]
        public string Title_ { get; set; }

        /// <summary>
        /// Access key for the audio
        /// </summary>
        [JsonProperty("access_key")]
        public string AccessKey { get; set; }

    }
}
