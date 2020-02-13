using System;
using Newtonsoft.Json;

namespace VkApi.Wrapper.Types.Photos
{
    public class PhotosImage
    {
        ///<summary>
        /// Height of the photo in px.
        ///</summary>
        [JsonProperty("height")]
        public int Height { get; set; }
        [JsonProperty("type")]
        public PhotosImageType Type { get; set; }

        ///<summary>
        /// Photo URL.
        ///</summary>
        [JsonProperty("url")]
        public String Url { get; set; }

        ///<summary>
        /// Width of the photo in px.
        ///</summary>
        [JsonProperty("width")]
        public int Width { get; set; }
    }
}