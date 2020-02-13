using Newtonsoft.Json;
using VkApi.Wrapper.Types.Photos;

namespace VkApi.Wrapper.Responses.Photos
{
    public class PhotosGetAllExtendedResponse
    {
        ///<summary>
        /// Total number
        ///</summary>
        [JsonProperty("count")]
        public int Count { get; set; }
        [JsonProperty("items")]
        public PhotosPhotoFullXtrRealOffset[] Items { get; set; }

        ///<summary>
        /// Information whether next page is presented
        ///</summary>
        [JsonProperty("more")]
        public int More { get; set; }
    }
}