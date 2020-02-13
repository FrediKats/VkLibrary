using System;
using Newtonsoft.Json;

namespace VkApi.Wrapper.Types.Photos
{
    public class PhotosPhotoSizes
    {
        ///<summary>
        /// Height in px
        ///</summary>
        [JsonProperty("height")]
        public int Height { get; set; }

        ///<summary>
        /// URL of the image
        ///</summary>
        [JsonProperty("url")]
        public String Url { get; set; }
        [JsonProperty("type")]
        public PhotosPhotoSizesType Type { get; set; }

        ///<summary>
        /// Width in px
        ///</summary>
        [JsonProperty("width")]
        public int Width { get; set; }
    }
}