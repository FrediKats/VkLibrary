using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using VkLib.Types;

namespace VkLib.Responses.Photos
{
    public class SaveOwnerPhotoResponse
    {
        /// <summary>
        /// Parameter for saveProfilePhoto method
        /// </summary>
        [JsonProperty("photo_hash")]
        public string PhotoHash { get; set; }

        /// <summary>
        /// Uploaded image url
        /// </summary>
        [JsonProperty("photo_src")]
        public string PhotoSrc { get; set; }

    }
}
