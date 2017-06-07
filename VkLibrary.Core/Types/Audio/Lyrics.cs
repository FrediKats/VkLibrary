using Newtonsoft.Json;

namespace VkLibrary.Core.Types.Audio
{
    /// <summary>
    /// API Lyrics object.
    /// </summary>
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
        public string Text { get; set; }
    }
}