using System;
using Newtonsoft.Json;

namespace VkApi.Wrapper.Types.Audio
{
    public class AudioAudio
    {
        ///<summary>
        /// Artist name
        ///</summary>
        [JsonProperty("artist")]
        public String Artist { get; set; }

        ///<summary>
        /// Audio ID
        ///</summary>
        [JsonProperty("id")]
        public int Id { get; set; }

        ///<summary>
        /// Title
        ///</summary>
        [JsonProperty("title")]
        public String Title { get; set; }

        ///<summary>
        /// URL of mp3 file
        ///</summary>
        [JsonProperty("url")]
        public String Url { get; set; }

        ///<summary>
        /// Duration in seconds
        ///</summary>
        [JsonProperty("duration")]
        public int Duration { get; set; }

        ///<summary>
        /// Date when uploaded
        ///</summary>
        [JsonProperty("date")]
        public int Date { get; set; }

        ///<summary>
        /// Album ID
        ///</summary>
        [JsonProperty("album_id")]
        public int AlbumId { get; set; }

        ///<summary>
        /// Genre ID
        ///</summary>
        [JsonProperty("genre_id")]
        public int GenreId { get; set; }

        ///<summary>
        /// Performer name
        ///</summary>
        [JsonProperty("performer")]
        public String Performer { get; set; }
    }
}