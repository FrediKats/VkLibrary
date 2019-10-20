using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace VkLibrary.Core.Objects
{
    public class UsersCropPhoto
    {
        [JsonProperty("crop")]
        public UsersCropPhotoCrop Crop { get; set; }
        [JsonProperty("photo")]
        public PhotosPhoto Photo { get; set; }
        [JsonProperty("rect")]
        public UsersCropPhotoRect Rect { get; set; }
    }
}