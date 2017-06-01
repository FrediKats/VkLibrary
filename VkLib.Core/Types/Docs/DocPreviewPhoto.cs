using System.Collections.Generic;
using Newtonsoft.Json;
using VkLib.Types.Photos;

namespace VkLib.Types.Docs
{
    public class DocPreviewPhoto
    {
        /// <summary>
        ///     Property
        /// </summary>
        [JsonProperty("sizes")]
        public IEnumerable<PhotoSizes> Sizes { get; set; }
    }
}