using System;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace VkLib.Types.Docs 
{
    public class DocPreview
    {
        /// <summary>
        /// Property
        /// </summary>
        [JsonProperty("photo")]
        public VkLib.Types.Docs.DocPreviewPhoto Photo { get; set; }

        /// <summary>
        /// Property
        /// </summary>
        [JsonProperty("video")]
        public VkLib.Types.Docs.DocPreviewVideo Video { get; set; }

        [JsonProperty("audio_msg")]
        public VkLib.Types.Docs.DocPreviewAudioMsg AudioMessage { get; set; }
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
