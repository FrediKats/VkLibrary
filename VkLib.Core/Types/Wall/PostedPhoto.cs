using System;
using Newtonsoft.Json;

namespace VkLib.Types.Wall 
{
    public class PostedPhoto
    {
        /// <summary>
        /// Photo ID
        /// </summary>
        [JsonProperty("id")]
        public int? Id { get; set; }

        /// <summary>
        /// URL of the preview image with 130 px in width
        /// </summary>
        [JsonProperty("photo_130")]
        public string Photo130 { get; set; }

        /// <summary>
        /// Photo owner's ID
        /// </summary>
        [JsonProperty("owner_id")]
        public int? OwnerId { get; set; }

        /// <summary>
        /// URL of the preview image with 604 px in width
        /// </summary>
        [JsonProperty("photo_604")]
        public string Photo604 { get; set; }

    }
}
