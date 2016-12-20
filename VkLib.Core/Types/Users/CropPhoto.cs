using System;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace VkLib.Types.Users 
{
    public class CropPhoto
    {
        /// <summary>
        /// Property
        /// </summary>
        [JsonProperty("rect")]
        public VkLib.Types.Users.CropPhotoRect Rect { get; set; }

        /// <summary>
        /// Property
        /// </summary>
        [JsonProperty("photo")]
        public VkLib.Types.Photos.Photo Photo { get; set; }

        /// <summary>
        /// Property
        /// </summary>
        [JsonProperty("crop")]
        public VkLib.Types.Users.CropPhotoCrop Crop { get; set; }

    }
}
