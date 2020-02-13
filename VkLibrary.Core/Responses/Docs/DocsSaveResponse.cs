using Newtonsoft.Json;
using VkApi.Wrapper.Types.Docs;
using VkApi.Wrapper.Types.Messages;

namespace VkApi.Wrapper.Responses.Docs
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