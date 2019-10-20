using Newtonsoft.Json;
using VkLibrary.Core.Objects;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace VkLibrary.Core.Responses
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