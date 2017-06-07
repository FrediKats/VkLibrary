using Newtonsoft.Json;

namespace VkLibrary.Core.Types.Base
{
    /// <summary>
    /// API Sticker object.
    /// </summary>
    public class Sticker
    {
        /// <summary>
        /// URL of the preview image with 256 px in height
        /// </summary>
        [JsonProperty("photo_256")]
        public string Photo256 { get; set; }

        /// <summary>
        /// URL of the preview image with 352 px in height
        /// </summary>
        [JsonProperty("photo_352")]
        public string Photo352 { get; set; }

        /// <summary>
        /// Sticker ID
        /// </summary>
        [JsonProperty("id")]
        public int? Id { get; set; }

        /// <summary>
        /// URL of the preview image with 128 px in height
        /// </summary>
        [JsonProperty("photo_128")]
        public string Photo128 { get; set; }

        /// <summary>
        /// Collection ID
        /// </summary>
        [JsonProperty("product_id")]
        public int? ProductId { get; set; }

        /// <summary>
        /// URL of the preview image with 64 px in height
        /// </summary>
        [JsonProperty("photo_64")]
        public string Photo64 { get; set; }

        /// <summary>
        /// Width in px
        /// </summary>
        [JsonProperty("width")]
        public int? Width { get; set; }

        /// <summary>
        /// Hieght in px
        /// </summary>
        [JsonProperty("height")]
        public int? Height { get; set; }
    }
}