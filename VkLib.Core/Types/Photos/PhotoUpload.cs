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
        public int? AlbumId_ { get; set; }

        /// <summary>
        /// URL to upload photo
        /// </summary>
        [JsonProperty("upload_url")]
        public string UploadUrl_ { get; set; }

        /// <summary>
        /// User ID
        /// </summary>
        [JsonProperty("user_id")]
        public int? UserId_ { get; set; }

    }
}
