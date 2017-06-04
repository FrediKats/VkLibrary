using Newtonsoft.Json;

namespace VkLibrary.Core.Types.Photos
{
    public class PhotoXtrTagInfo : Photo
    {
        /// <summary>
        /// Tag ID
        /// </summary>
        [JsonProperty("tag_id")]
        public int? TagId { get; set; }

        /// <summary>
        /// Date when tag has been added in Unixtime
        /// </summary>
        [JsonProperty("tag_created")]
        public int? TagCreated { get; set; }

        /// <summary>
        /// ID of the tag creator
        /// </summary>
        [JsonProperty("placer_id")]
        public int? PlacerId { get; set; }
    }
}