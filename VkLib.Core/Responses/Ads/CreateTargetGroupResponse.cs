using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using VkLib.Types;

namespace VkLib.Responses.Ads
{
    public class CreateTargetGroupResponse
    {
        /// <summary>
        /// Group ID
        /// </summary>
        [JsonProperty("id")]
        public int? Id { get; set; }

        /// <summary>
        /// Pixel code
        /// </summary>
        [JsonProperty("pixel")]
        public string Pixel { get; set; }

    }
}
