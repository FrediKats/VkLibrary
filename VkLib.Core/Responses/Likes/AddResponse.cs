using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using VkLib.Types;

namespace VkLib.Responses.Likes
{
    public class AddResponse
    {
        /// <summary>
        /// Total likes number
        /// </summary>
        [JsonProperty("likes")]
        public int? Likes { get; set; }

    }
}
