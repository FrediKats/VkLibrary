using System;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace VkLib.Types.Wall 
{
    public class PostedPhoto
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
        /// Photo ID
        /// </summary>
        [JsonProperty("id")]
        public int? Id { get; set; }

        /// <summary>
        /// Photo owner's ID
        /// </summary>
        [JsonProperty("owner_id")]
        public int? OwnerId_ { get; set; }

    }
}
