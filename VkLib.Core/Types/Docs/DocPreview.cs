using System;
using Newtonsoft.Json;

namespace VkLib.Types.Docs 
{
    public class DocPreview
    {
        /// <summary>
        /// Property
        /// </summary>
        [JsonProperty("video")]
        public DocPreviewVideo Video { get; set; }

        /// <summary>
        /// Property
        /// </summary>
        [JsonProperty("photo")]
        public DocPreviewPhoto Photo { get; set; }

    }
}
