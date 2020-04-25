using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace VkApi.Wrapper.Objects
{
    public class NewsfeedItemPhotoPhotos
    {
        ///<summary>
        /// Photos number
        ///</summary>
        [JsonProperty("count")]
        public int Count { get; set; }
        [JsonProperty("items")]
        public NewsfeedNewsfeedPhoto[] Items { get; set; }
    }
}