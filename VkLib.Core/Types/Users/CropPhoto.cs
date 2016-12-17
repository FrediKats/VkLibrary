using System;
using Newtonsoft.Json;

namespace VkLib.Types.Users 
{
    public class CropPhoto
    {
        /// <summary>
        /// Property
        /// </summary>
        [JsonProperty("crop")]
        public CropPhotoCrop Crop { get; set; }

        /// <summary>
        /// Property
        /// </summary>
        [JsonProperty("photo")]
        public Photo Photo { get; set; }

        /// <summary>
        /// Property
        /// </summary>
        [JsonProperty("rect")]
        public CropPhotoRect Rect { get; set; }

    }
}
