using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace VkApi.Wrapper.Objects
{
    public class VideoVideoImage : BaseImage
    {
        [JsonProperty("with_padding")]
        public BasePropertyExists WithPadding { get; set; }
    }
}