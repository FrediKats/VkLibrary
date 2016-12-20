using System;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace VkLib.Types.Docs 
{
    public class DocPreviewVideo
    {
        /// <summary>
        /// Video's width in pixels
        /// </summary>
        [JsonProperty("width")]
        public int? Width { get; set; }

        /// <summary>
        /// Video URL
        /// </summary>
        [JsonProperty("src")]
        public string Src { get; set; }

        /// <summary>
        /// Video file size in bites
        /// </summary>
        [JsonProperty("filesize")]
        public int? Filesize { get; set; }

        /// <summary>
        /// Video's height in pixels
        /// </summary>
        [JsonProperty("height")]
        public int? Height { get; set; }

    }
}
