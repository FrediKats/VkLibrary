using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace VkApi.Wrapper.Objects
{
    public class MessagesAudioMessage
    {
        ///<summary>
        /// Access key for audio message
        ///</summary>
        [JsonProperty("access_key")]
        public String AccessKey { get; set; }

        ///<summary>
        /// Audio message duration in seconds
        ///</summary>
        [JsonProperty("duration")]
        public int Duration { get; set; }

        ///<summary>
        /// Audio message ID
        ///</summary>
        [JsonProperty("id")]
        public int Id { get; set; }

        ///<summary>
        /// MP3 file URL
        ///</summary>
        [JsonProperty("link_mp3")]
        public String LinkMp3 { get; set; }

        ///<summary>
        /// OGG file URL
        ///</summary>
        [JsonProperty("link_ogg")]
        public String LinkOgg { get; set; }

        ///<summary>
        /// Audio message owner ID
        ///</summary>
        [JsonProperty("owner_id")]
        public int OwnerId { get; set; }
        [JsonProperty("waveform")]
        public int[] Waveform { get; set; }
    }
}