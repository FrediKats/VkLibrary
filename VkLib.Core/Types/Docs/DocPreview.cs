using System.Collections.Generic;
using Newtonsoft.Json;

namespace VkLib.Types.Docs
{
    public class DocPreview
    {
        /// <summary>
        ///     Property
        /// </summary>
        [JsonProperty("photo")]
        public DocPreviewPhoto Photo { get; set; }

        /// <summary>
        ///     Property
        /// </summary>
        [JsonProperty("video")]
        public DocPreviewVideo Video { get; set; }

        [JsonProperty("audio_msg")]
        public DocPreviewAudioMsg AudioMessage { get; set; }
    }

    public class DocPreviewAudioMsg
    {
        [JsonProperty("duration")]
        public int? Duration { get; set; }

        [JsonProperty("waveform")]
        public IEnumerable<int> Waveform { get; set; }

        [JsonProperty("link_ogg")]
        public string LinkOgg { get; set; }

        [JsonProperty("link_mp3")]
        public string LinkMp3 { get; set; }
    }
}