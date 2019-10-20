using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace VkLibrary.Core.Objects
{
    public class NewsfeedItemVideo
    {
        [JsonProperty("video")]
        public NewsfeedItemVideoVideo Video { get; set; }
    }
}