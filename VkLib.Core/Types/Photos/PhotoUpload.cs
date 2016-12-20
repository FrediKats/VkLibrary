using System;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace VkLib.Types.Photos 
{
    public class PhotoUpload
    {
        /// <summary>
        /// Album ID
        /// </summary>
        [JsonProperty("album_id")]
        public int? AlbumId { get; set; }

        /// <summary>
        /// User ID
        /// </summary>
        [JsonProperty("user_id")]
        public int? UserId { get; set; }

        /// <summary>
        /// URL to upload photo
        /// </summary>
        [JsonProperty("upload_url")]
        public string UploadUrl { get; set; }

    }
}
