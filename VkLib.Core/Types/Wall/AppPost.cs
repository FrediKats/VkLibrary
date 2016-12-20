using System;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace VkLib.Types.Wall 
{
    public class AppPost
    {
        /// <summary>
        /// URL of the preview image with 604 px in width
        /// </summary>
        [JsonProperty("photo_604")]
        public string Photo604_ { get; set; }

        /// <summary>
        /// URL of the preview image with 130 px in width
        /// </summary>
        [JsonProperty("photo_130")]
        public string Photo130_ { get; set; }

        /// <summary>
        /// Application name
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Application ID
        /// </summary>
        [JsonProperty("id")]
        public int? Id { get; set; }

    }
}
