using Newtonsoft.Json;

namespace VkLib.Types.Video
{
    public class Video
    {
        /// <summary>
        ///     Video title
        /// </summary>
        [JsonProperty("title")]
        public string Title { get; set; }

        /// <summary>
        ///     Video duration in seconds
        /// </summary>
        [JsonProperty("duration")]
        public double? Duration { get; set; }

        /// <summary>
        ///     Video ID
        /// </summary>
        [JsonProperty("id")]
        public int? Id { get; set; }

        /// <summary>
        ///     URL of the preview image with 130 px in width
        /// </summary>
        [JsonProperty("photo_130")]
        public string Photo130 { get; set; }

        /// <summary>
        ///     Date when the video has been added in Unixtime
        /// </summary>
        [JsonProperty("adding_date")]
        public int? AddingDate { get; set; }

        /// <summary>
        ///     Video access key
        /// </summary>
        [JsonProperty("access_key")]
        public string AccessKey { get; set; }

        /// <summary>
        ///     Information whether current user can add the video
        /// </summary>
        [JsonProperty("can_add")]
        public int? CanAdd { get; set; }

        /// <summary>
        ///     Information whether current user can edit the video
        /// </summary>
        [JsonProperty("can_edit")]
        public int? CanEdit { get; set; }

        /// <summary>
        ///     URL of the preview image with 320 px in width
        /// </summary>
        [JsonProperty("photo_320")]
        public string Photo320 { get; set; }

        /// <summary>
        ///     URL of the preview image with 800 px in width
        /// </summary>
        [JsonProperty("photo_800")]
        public string Photo800 { get; set; }

        /// <summary>
        ///     Number of views
        /// </summary>
        [JsonProperty("views")]
        public int? Views { get; set; }

        /// <summary>
        ///     Number of comments
        /// </summary>
        [JsonProperty("comments")]
        public int? Comments { get; set; }

        /// <summary>
        ///     Date when video has been uploaded in Unixtime
        /// </summary>
        [JsonProperty("date")]
        public double? Date { get; set; }

        /// <summary>
        ///     Video owner ID
        /// </summary>
        [JsonProperty("owner_id")]
        public int? OwnerId { get; set; }

        /// <summary>
        ///     Video description
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        ///     Property
        /// </summary>
        [JsonProperty("files")]
        public VideoFiles Files { get; set; }

        /// <summary>
        ///     Returns if the video is live translation
        /// </summary>
        [JsonProperty("live")]
        public string Live { get; set; }

        /// <summary>
        ///     URL of the page with a player that can be used to play the video in the browser.
        /// </summary>
        [JsonProperty("player")]
        public string Player { get; set; }

        /// <summary>
        ///     Returns if the video is processing
        /// </summary>
        [JsonProperty("processing")]
        public string Processing { get; set; }
    }
}