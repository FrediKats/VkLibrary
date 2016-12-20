using System;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace VkLib.Types.Audio 
{
    public class Lyrics
    {
        /// <summary>
        /// Lyrics ID
        /// </summary>
        [JsonProperty("lyrics_id")]
        public int? LyricsId { get; set; }

        /// <summary>
        /// Lyrics text
        /// </summary>
        [JsonProperty("text")]
        public string Text_ { get; set; }

    }
}
