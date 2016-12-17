using System;
using Newtonsoft.Json;

namespace VkLib.Types.Wall 
{
    public class Graffiti
    {
        /// <summary>
        /// URL of the preview image with 586 px in width
        /// </summary>
        [JsonProperty("photo_586")]
        public string Photo586 { get; set; }

        /// <summary>
        /// Graffiti ID
        /// </summary>
        [JsonProperty("id")]
        public int? Id { get; set; }

        /// <summary>
        /// Graffiti owner's ID
        /// </summary>
        [JsonProperty("owner_id")]
        public int? OwnerId { get; set; }

        /// <summary>
        /// URL of the preview image with 200 px in width
        /// </summary>
        [JsonProperty("photo_200")]
        public string Photo200 { get; set; }

    }
}
