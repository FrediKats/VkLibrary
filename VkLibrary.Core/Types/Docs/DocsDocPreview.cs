using Newtonsoft.Json;

namespace VkApi.Wrapper.Types.Docs
{
    public class DocsDocPreview
    {
        [JsonProperty("photo")]
        public DocsDocPreviewPhoto Photo { get; set; }
        [JsonProperty("video")]
        public DocsDocPreviewVideo Video { get; set; }
    }
}