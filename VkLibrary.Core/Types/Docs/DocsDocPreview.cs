using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace VkLibrary.Core.Objects
{
    public class DocsDocPreview
    {
        [JsonProperty("photo")]
        public DocsDocPreviewPhoto Photo { get; set; }
        [JsonProperty("video")]
        public DocsDocPreviewVideo Video { get; set; }
    }
}