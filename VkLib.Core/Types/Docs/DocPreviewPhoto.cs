using System;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace VkLib.Types.Docs 
{
    public class DocPreviewPhoto
    {
        /// <summary>
        /// Property
        /// </summary>
        [JsonProperty("sizes")]
        public IEnumerable<VkLib.Types.Photos.PhotoSizes> Sizes { get; set; }

    }
}
