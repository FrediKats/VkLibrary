using Newtonsoft.Json;

namespace VkLibrary.Core.Types.Photos
{
    /// <summary>
    /// API PhotoTag object.
    /// </summary>
    public class PhotoTag
    {
        /// <summary>
        /// Date when tag has been added in Unixtime
        /// </summary>
        [JsonProperty("date")]
        public int? Date { get; set; }

        /// <summary>
        /// Tag ID
        /// </summary>
        [JsonProperty("id")]
        public int? Id { get; set; }

        /// <summary>
        /// Information whether the tag is reviewed
        /// </summary>
        [JsonProperty("viewed")]
        public int? Viewed { get; set; }

        /// <summary>
        /// Tag description
        /// </summary>
        [JsonProperty("tagged_name")]
        public string TaggedName { get; set; }

        /// <summary>
        /// Coordinate X of the left upper corner
        /// </summary>
        [JsonProperty("x")]
        public uint? X { get; set; }

        /// <summary>
        /// Coordinate Y of the right lower corner
        /// </summary>
        [JsonProperty("y2")]
        public uint? Y2 { get; set; }

        /// <summary>
        /// Tagged user ID
        /// </summary>
        [JsonProperty("user_id")]
        public int? UserId { get; set; }

        /// <summary>
        /// Coordinate Y of the left upper corner
        /// </summary>
        [JsonProperty("y")]
        public uint? Y { get; set; }

        /// <summary>
        /// ID of the tag creator
        /// </summary>
        [JsonProperty("placer_id")]
        public int? PlacerId { get; set; }

        /// <summary>
        /// Coordinate X of the right lower corner
        /// </summary>
        [JsonProperty("x2")]
        public uint? X2 { get; set; }
    }
}