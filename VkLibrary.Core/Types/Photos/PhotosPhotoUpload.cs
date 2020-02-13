using System;
using Newtonsoft.Json;

namespace VkApi.Wrapper.Types.Photos
{
    public class PhotosPhotoUpload
    {
        ///<summary>
        /// Album ID
        ///</summary>
        [JsonProperty("album_id")]
        public int AlbumId { get; set; }

        ///<summary>
        /// URL to upload photo
        ///</summary>
        [JsonProperty("upload_url")]
        public String UploadUrl { get; set; }

        ///<summary>
        /// User ID
        ///</summary>
        [JsonProperty("user_id")]
        public int UserId { get; set; }
    }
}