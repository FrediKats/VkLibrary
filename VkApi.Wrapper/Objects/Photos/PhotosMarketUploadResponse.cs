using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace VkApi.Wrapper.Objects
{
    public class PhotosMarketUploadResponse
    {
        ///<summary>
        /// Crop data
        ///</summary>
        [JsonProperty("crop_data")]
        public String CropData { get; set; }

        ///<summary>
        /// Crop hash
        ///</summary>
        [JsonProperty("crop_hash")]
        public String CropHash { get; set; }

        ///<summary>
        /// Community ID
        ///</summary>
        [JsonProperty("group_id")]
        public int GroupId { get; set; }

        ///<summary>
        /// Uploading hash
        ///</summary>
        [JsonProperty("hash")]
        public String Hash { get; set; }

        ///<summary>
        /// Uploaded photo data
        ///</summary>
        [JsonProperty("photo")]
        public String Photo { get; set; }

        ///<summary>
        /// Upload server number
        ///</summary>
        [JsonProperty("server")]
        public int Server { get; set; }
    }
}