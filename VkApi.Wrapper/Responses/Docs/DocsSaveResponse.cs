using Newtonsoft.Json;
using VkApi.Wrapper.Objects;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace VkApi.Wrapper.Responses
{
    public class DocsSaveResponse
    {
        [JsonProperty("type")]
        public DocsDocAttachmentType Type { get; set; }
        [JsonProperty("audio_message")]
        public MessagesAudioMessage AudioMessage { get; set; }
        [JsonProperty("doc")]
        public DocsDoc Doc { get; set; }
        [JsonProperty("graffiti")]
        public MessagesGraffiti Graffiti { get; set; }
    }
}