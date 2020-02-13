using Newtonsoft.Json;
using VkApi.Wrapper.Types.Photos;

namespace VkApi.Wrapper.Responses.Photos
{
    public class PhotosGetAllCommentsResponse
    {
        ///<summary>
        /// Total number
        ///</summary>
        [JsonProperty("count")]
        public int Count { get; set; }
        [JsonProperty("items")]
        public PhotosCommentXtrPid[] Items { get; set; }
    }
}