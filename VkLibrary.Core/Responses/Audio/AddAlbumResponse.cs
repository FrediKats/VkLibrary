using Newtonsoft.Json;

namespace VkLibrary.Core.Responses.Audio
{
    /// <summary>
    /// API AddAlbumResponse.
    /// </summary>
    public class AddAlbumResponse
    {
        /// <summary>
        /// Created album ID
        /// </summary>
        [JsonProperty("album_id")]
        public int? AlbumId { get; set; }
    }
}