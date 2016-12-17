using System;
using Newtonsoft.Json;

namespace VkLib.Types.Photos 
{
    public class PhotoSizes
    {
        /// <summary>
        /// URL of the image
        /// </summary>
        [JsonProperty("src")]
        public string Src { get; set; }

        /// <summary>
        /// Height in px
        /// </summary>
        [JsonProperty("height")]
        public int? Height { get; set; }

        /// <summary>
        /// Width in px
        /// </summary>
        [JsonProperty("width")]
        public int? Width { get; set; }

        /// <summary>
        /// Size type
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }

    }
}
