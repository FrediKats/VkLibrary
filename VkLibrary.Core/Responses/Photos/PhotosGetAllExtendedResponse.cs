using Newtonsoft.Json;
using VkLibrary.Core.Objects;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace VkLibrary.Core.Responses
{
    public class PhotosGetAllExtendedResponse
    {
        ///<summary>
        /// Total number
        ///</summary>
        [JsonProperty("count")]
        public int Count { get; set; }
        [JsonProperty("items")]
        public PhotosPhotoFullXtrRealOffset[] Items { get; set; }

        ///<summary>
        /// Information whether next page is presented
        ///</summary>
        [JsonProperty("more")]
        public int More { get; set; }
    }
}