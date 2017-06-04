using Newtonsoft.Json;

namespace VkLibrary.Core.Types.Gifts
{
    public class Layout
    {
        /// <summary>
        /// URL of the preview image with 96 px in width
        /// </summary>
        [JsonProperty("thumb_96")]
        public string Thumb96 { get; set; }

        /// <summary>
        /// URL of the preview image with 256 px in width
        /// </summary>
        [JsonProperty("thumb_256")]
        public string Thumb256 { get; set; }

        /// <summary>
        /// Gift ID
        /// </summary>
        [JsonProperty("id")]
        public int? Id { get; set; }

        /// <summary>
        /// URL of the preview image with 48 px in width
        /// </summary>
        [JsonProperty("thumb_48")]
        public string Thumb48 { get; set; }
    }
}