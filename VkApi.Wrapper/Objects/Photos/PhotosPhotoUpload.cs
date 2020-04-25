using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace VkApi.Wrapper.Objects
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
        /// Fallback URL if upload_url returned error
        ///</summary>
        [JsonProperty("fallback_upload_url")]
        public String FallbackUploadUrl { get; set; }

        ///<summary>
        /// User ID
        ///</summary>
        [JsonProperty("user_id")]
        public int UserId { get; set; }

        ///<summary>
        /// Group ID
        ///</summary>
        [JsonProperty("group_id")]
        public int GroupId { get; set; }
    }
}