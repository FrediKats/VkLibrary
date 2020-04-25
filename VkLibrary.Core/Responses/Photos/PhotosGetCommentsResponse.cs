using Newtonsoft.Json;
using VkApi.Wrapper.Objects;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace VkApi.Wrapper.Responses
{
    public class PhotosGetCommentsResponse
    {
        ///<summary>
        /// Total number
        ///</summary>
        [JsonProperty("count")]
        public int Count { get; set; }

        ///<summary>
        /// Real offset of the comments
        ///</summary>
        [JsonProperty("real_offset")]
        public int RealOffset { get; set; }
        [JsonProperty("items")]
        public WallWallComment[] Items { get; set; }
    }
}