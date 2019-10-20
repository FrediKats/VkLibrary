using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace VkLibrary.Core.Objects
{
    public class NewsfeedItemPhotoTagPhotoTags
    {
        ///<summary>
        /// Tags number
        ///</summary>
        [JsonProperty("count")]
        public int Count { get; set; }
        [JsonProperty("items")]
        public NewsfeedNewsfeedPhoto[] Items { get; set; }
    }
}