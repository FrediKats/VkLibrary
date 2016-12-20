using System;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace VkLib.Types.Audio 
{
    public class Audio
    {
        /// <summary>
        /// Audio ID
        /// </summary>
        [JsonProperty("id")]
        public int? Id { get; set; }

        /// <summary>
        /// Audio owner's ID
        /// </summary>
        [JsonProperty("owner_id")]
        public int? OwnerId { get; set; }

        /// <summary>
        /// Access key for the audio
        /// </summary>
        [JsonProperty("access_key")]
        public string AccessKey { get; set; }

        /// <summary>
        /// URL of mp3 file
        /// </summary>
        [JsonProperty("url")]
        public string Url { get; set; }

        /// <summary>
        /// Title
        /// </summary>
        [JsonProperty("title")]
        public string Title { get; set; }

        /// <summary>
        /// Artist name
        /// </summary>
        [JsonProperty("artist")]
        public string Artist { get; set; }

    }
}
