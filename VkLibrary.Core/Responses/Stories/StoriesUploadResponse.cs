using Newtonsoft.Json;
using VkApi.Wrapper.Types.Stories;

namespace VkApi.Wrapper.Responses.Stories
{
    public class StoriesUploadResponse
    {
        [JsonProperty("story")]
        public StoriesStory Story { get; set; }
    }
}