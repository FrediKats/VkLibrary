using System;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace VkLib.Types.Newsfeed 
{
    public class ItemWallpost : VkLib.Types.Wall.WallpostFull
    {

        /// <summary>
        /// Post ID
        /// </summary>
        [JsonProperty("post_id")]
        public int? PostId { get; set; }

        /// <summary>
        /// Post's Author
        /// </summary>
        [JsonProperty("source_id")]
        public int? SourceId { get; set; }

    }
}
