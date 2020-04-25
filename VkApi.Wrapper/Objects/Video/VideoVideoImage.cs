using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace VkApi.Wrapper.Objects
{
    public class VideoVideoImage
    {
        [JsonProperty("with_padding")]
        public BasePropertyExists WithPadding { get; set; }
    }
}