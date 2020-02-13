using System;
using Newtonsoft.Json;

namespace VkApi.Wrapper.Types.Photos
{
    public class PhotosPhotoUploadResponse
    {
        ///<summary>
        /// Album ID
        ///</summary>
        [JsonProperty("aid")]
        public int Aid { get; set; }

        ///<summary>
        /// Uploading hash
        ///</summary>
        [JsonProperty("hash")]
        public String Hash { get; set; }

        ///<summary>
        /// Uploaded photos data
        ///</summary>
        [JsonProperty("photos_list")]
        public String PhotosList { get; set; }

        ///<summary>
        /// Upload server number
        ///</summary>
        [JsonProperty("server")]
        public int Server { get; set; }
    }
}