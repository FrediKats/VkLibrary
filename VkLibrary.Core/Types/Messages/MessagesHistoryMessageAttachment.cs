using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace VkLibrary.Core.Objects
{
    public class MessagesHistoryMessageAttachment
    {
        [JsonProperty("audio")]
        public AudioAudio Audio { get; set; }
        [JsonProperty("audio_message")]
        public MessagesAudioMessage AudioMessage { get; set; }
        [JsonProperty("doc")]
        public DocsDoc Doc { get; set; }
        [JsonProperty("graffiti")]
        public MessagesGraffiti Graffiti { get; set; }
        [JsonProperty("link")]
        public BaseLink Link { get; set; }
        [JsonProperty("market")]
        public BaseLink Market { get; set; }
        [JsonProperty("photo")]
        public PhotosPhoto Photo { get; set; }
        [JsonProperty("share")]
        public BaseLink Share { get; set; }
        [JsonProperty("type")]
        public MessagesHistoryMessageAttachmentType Type { get; set; }
        [JsonProperty("video")]
        public VideoVideo Video { get; set; }
        [JsonProperty("wall")]
        public BaseLink Wall { get; set; }
    }
}