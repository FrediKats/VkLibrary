using Newtonsoft.Json;
using VkApi.Wrapper.Types.Photos;

namespace VkApi.Wrapper.Responses.Photos
{
    public class PhotosGetResponse
    {
        ///<summary>
        /// Total number
        ///</summary>
        [JsonProperty("count")]
        public int Count { get; set; }
        [JsonProperty("items")]
        public PhotosPhoto[] Items { get; set; }
    }
}