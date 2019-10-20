using Newtonsoft.Json;
using VkLibrary.Core.Objects;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace VkLibrary.Core.Responses
{
    public class VideoAddAlbumResponse
    {
        ///<summary>
        /// Created album ID
        ///</summary>
        [JsonProperty("album_id")]
        public int AlbumId { get; set; }
    }
}