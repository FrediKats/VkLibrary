using Newtonsoft.Json;
using VkApi.Wrapper.Objects;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace VkApi.Wrapper.Responses
{
    public class PhotosSaveOwnerPhotoResponse
    {
        ///<summary>
        /// Photo hash
        ///</summary>
        [JsonProperty("photo_hash")]
        public String PhotoHash { get; set; }

        ///<summary>
        /// Uploaded image url
        ///</summary>
        [JsonProperty("photo_src")]
        public String PhotoSrc { get; set; }

        ///<summary>
        /// Uploaded image url
        ///</summary>
        [JsonProperty("photo_src_big")]
        public String PhotoSrcBig { get; set; }

        ///<summary>
        /// Uploaded image url
        ///</summary>
        [JsonProperty("photo_src_small")]
        public String PhotoSrcSmall { get; set; }

        ///<summary>
        /// Returns 1 if profile photo is saved
        ///</summary>
        [JsonProperty("saved")]
        public int Saved { get; set; }

        ///<summary>
        /// Created post ID
        ///</summary>
        [JsonProperty("post_id")]
        public int PostId { get; set; }
    }
}