using System;
using Newtonsoft.Json;

namespace VkLib.Types.Docs 
{
    public class DocPreviewPhoto
    {
        /// <summary>
        /// Property
        /// </summary>
        [JsonProperty("sizes")]
        public IEnumerable<PhotoSizes> Sizes { get; set; }

    }
}
