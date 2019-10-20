using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace VkLibrary.Core.Objects
{
    public class VideoVideoImage
    {
        [JsonProperty("with_padding")]
        public int WithPadding { get; set; }
    }
}