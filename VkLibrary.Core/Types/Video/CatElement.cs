using Newtonsoft.Json;

namespace VkLibrary.Core.Types.Video
{
    /// <summary>
    /// API CatElement object.
    /// </summary>
    public class CatElement
    {
        /// <summary>
        /// Videos number (for album)
        /// </summary>
        [JsonProperty("count")]
        public int? Count { get; set; }

        /// <summary>
        /// Element title
        /// </summary>
        [JsonProperty("title")]
        public string Title { get; set; }

        /// <summary>
        /// Duration in seconds
        /// </summary>
        [JsonProperty("duration")]
        public int? Duration { get; set; }

        /// <summary>
        /// Element ID
        /// </summary>
        [JsonProperty("id")]
        public int? Id { get; set; }

        /// <summary>
        /// URL of the preview image with 130 px in width
        /// </summary>
        [JsonProperty("photo_130")]
        public string Photo130 { get; set; }

        /// <summary>
        /// Information whether current user can edit the video
        /// </summary>
        [JsonProperty("can_edit")]
        public int? CanEdit { get; set; }

        /// <summary>
        /// Information whether the video is private
        /// </summary>
        [JsonProperty("is_private")]
        public int? IsPrivate { get; set; }

        /// <summary>
        /// Date when the element has been created
        /// </summary>
        [JsonProperty("date")]
        public int? Date { get; set; }

        /// <summary>
        /// URL of the preview image with 320 px in width
        /// </summary>
        [JsonProperty("photo_320")]
        public string Photo320 { get; set; }

        /// <summary>
        /// URL of the preview image with 800 px in width
        /// </summary>
        [JsonProperty("photo_800")]
        public string Photo800 { get; set; }

        /// <summary>
        /// Views number
        /// </summary>
        [JsonProperty("views")]
        public int? Views { get; set; }

        /// <summary>
        /// Comments number
        /// </summary>
        [JsonProperty("comments")]
        public int? Comments { get; set; }

        /// <summary>
        /// URL of the preview image with 160 px in width
        /// </summary>
        [JsonProperty("photo_160")]
        public string Photo160 { get; set; }

        /// <summary>
        /// Element type
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }

        /// <summary>
        /// Element owner's ID
        /// </summary>
        [JsonProperty("owner_id")]
        public int? OwnerId { get; set; }

        /// <summary>
        /// Element description
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        /// Date of last update (for album) in Unixtime
        /// </summary>
        [JsonProperty("updated_time")]
        public int? UpdatedTime { get; set; }

        /// <summary>
        /// Information whether current user can add the video
        /// </summary>
        [JsonProperty("can_add")]
        public int? CanAdd { get; set; }

        /// <summary>
        /// URL of the preview image with 640 px in width
        /// </summary>
        [JsonProperty("photo_640")]
        public string Photo640 { get; set; }
    }
}