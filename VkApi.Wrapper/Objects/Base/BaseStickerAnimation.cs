using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace VkApi.Wrapper.Objects
{
    public class BaseStickerAnimation
    {
        ///<summary>
        /// Type of animation script
        ///</summary>
        [JsonProperty("type")]
        public String Type { get; set; }

        ///<summary>
        /// URL of animation script
        ///</summary>
        [JsonProperty("url")]
        public String Url { get; set; }
    }
}