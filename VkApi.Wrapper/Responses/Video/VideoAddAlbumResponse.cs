using Newtonsoft.Json;
using VkApi.Wrapper.Objects;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace VkApi.Wrapper.Responses
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