using System.Collections.Generic;
using Newtonsoft.Json;
using VkLibrary.Core.Types.Photos;

namespace VkLibrary.Core.Types.Docs
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