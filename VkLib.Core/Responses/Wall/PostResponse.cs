using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using VkLib.Types;

namespace VkLib.Responses.Wall
{
    public class PostResponse
    {
        /// <summary>
        /// Created post ID
        /// </summary>
        [JsonProperty("post_id")]
        public int? PostId { get; set; }

    }
}
