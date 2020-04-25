using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace VkApi.Wrapper.Objects
{
    public class DocsDocPreviewPhoto
    {
        [JsonProperty("sizes")]
        public PhotosPhotoSizes[] Sizes { get; set; }
    }
}