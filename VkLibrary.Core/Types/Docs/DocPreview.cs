using System.Collections.Generic;
using Newtonsoft.Json;

namespace VkLibrary.Core.Types.Docs
{
    /// <summary>
    /// API DocPreview object.
    /// </summary>
    public class DocPreview
    {
        /// <summary>
        /// Property
        /// </summary>
        [JsonProperty("photo")]
        public DocPreviewPhoto Photo { get; set; }

        /// <summary>
        /// Property
        /// </summary>
        [JsonProperty("video")]
        public DocPreviewVideo Video { get; set; }

        /// <summary>
        /// Doc preview audio message (if contains, otherwise null)
        /// </summary>
        [JsonProperty("audio_msg")]
        public DocPreviewAudioMsg AudioMessage { get; set; }
    }

    /// <summary>
    /// API DocPreview object.
    /// </summary>
    public class DocPreviewAudioMsg
    {
        /// <summary>
        /// Audio duration.
        /// </summary>
        [JsonProperty("duration")]
        public int? Duration { get; set; }

        /// <summary>
        /// Audio waveform.
        /// </summary>
        [JsonProperty("waveform")]
        public IEnumerable<int> Waveform { get; set; }

        /// <summary>
        /// Link to ogg file.
        /// </summary>
        [JsonProperty("link_ogg")]
        public string LinkOgg { get; set; }

        /// <summary>
        /// Link to mp3 file.
        /// </summary>
        [JsonProperty("link_mp3")]
        public string LinkMp3 { get; set; }
    }
}