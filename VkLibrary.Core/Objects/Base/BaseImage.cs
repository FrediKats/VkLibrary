using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace VkApi.Wrapper.Objects
{
    public class BaseImage
    {
        [JsonProperty("id")]
        public String Id { get; set; }

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