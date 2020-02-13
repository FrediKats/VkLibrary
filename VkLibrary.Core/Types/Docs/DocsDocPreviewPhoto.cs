using Newtonsoft.Json;
using VkApi.Wrapper.Types.Photos;

namespace VkApi.Wrapper.Types.Docs
{
    public class DocsDocPreviewPhoto
    {
        [JsonProperty("sizes")]
        public PhotosPhotoSizes[] Sizes { get; set; }
    }
}