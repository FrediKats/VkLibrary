using Newtonsoft.Json;

namespace VkLib.Responses.Video
{
    public class AddAlbumResponse
    {
        /// <summary>
        ///     Created album ID
        /// </summary>
        [JsonProperty("album_id")]
        public int? AlbumId { get; set; }
    }
}