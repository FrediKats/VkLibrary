using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using VkLib.Types;

namespace VkLib.Responses.Photos
{
    public class GetOwnerPhotoUploadServerResponse
    {
        /// <summary>
        /// URL to upload the photo
        /// </summary>
        [JsonProperty("upload_url")]
        public string UploadUrl { get; set; }

    }
}
