using Newtonsoft.Json;

namespace VkApi.Wrapper.Responses.Video
{
    public class VideoAddAlbumResponse
    {
        ///<summary>
        /// Created album ID
        ///</summary>
        [JsonProperty("album_id")]
        public int AlbumId { get; set; }
    }
}