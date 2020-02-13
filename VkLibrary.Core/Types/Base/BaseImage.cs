using System;
using Newtonsoft.Json;

namespace VkApi.Wrapper.Types.Base
{
    public class BaseImage
    {
        ///<summary>
        /// Image height
        ///</summary>
        [JsonProperty("height")]
        public int Height { get; set; }

        ///<summary>
        /// Image url
        ///</summary>
        [JsonProperty("url")]
        public String Url { get; set; }

        ///<summary>
        /// Image width
        ///</summary>
        [JsonProperty("width")]
        public int Width { get; set; }
    }
}