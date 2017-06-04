using Newtonsoft.Json;

namespace VkLibrary.Core.Responses.Video
{
    public class AddAlbumResponse
    {
        /// <summary>
        /// Created album ID
        /// </summary>
        [JsonProperty("album_id")]
        public int? AlbumId { get; set; }
    }
}