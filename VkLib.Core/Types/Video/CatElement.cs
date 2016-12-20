using System;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace VkLib.Types.Video 
{
    public class CatElement
    {
        /// <summary>
        /// Information whether current user can edit the video
        /// </summary>
        [JsonProperty("can_edit")]
        public int? CanEdit_ { get; set; }

        /// <summary>
        /// Information whether current user can add the video
        /// </summary>
        [JsonProperty("can_add")]
        public int? CanAdd_ { get; set; }

        /// <summary>
        /// Element type
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }

        /// <summary>
        /// Videos number (for album)
        /// </summary>
        [JsonProperty("count")]
        public int? Count { get; set; }

        /// <summary>
        /// Date when the element has been created
        /// </summary>
        [JsonProperty("date")]
        public int? Date { get; set; }

        /// <summary>
        /// Element owner's ID
        /// </summary>
        [JsonProperty("owner_id")]
        public int? OwnerId_ { get; set; }

        /// <summary>
        /// URL of the preview image with 320 px in width
        /// </summary>
        [JsonProperty("photo_320")]
        public string Photo320_ { get; set; }

        /// <summary>
        /// Comments number
        /// </summary>
        [JsonProperty("comments")]
        public int? Comments { get; set; }

        /// <summary>
        /// Element description
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        /// Views number
        /// </summary>
        [JsonProperty("views")]
        public int? Views { get; set; }

        /// <summary>
        /// URL of the preview image with 160 px in width
        /// </summary>
        [JsonProperty("photo_160")]
        public string Photo160_ { get; set; }

        /// <summary>
        /// Information whether the video is private
        /// </summary>
        [JsonProperty("is_private")]
        public int? IsPrivate_ { get; set; }

        /// <summary>
        /// URL of the preview image with 800 px in width
        /// </summary>
        [JsonProperty("photo_800")]
        public string Photo800_ { get; set; }

        /// <summary>
        /// Element ID
        /// </summary>
        [JsonProperty("id")]
        public int? Id { get; set; }

        /// <summary>
        /// Date of last update (for album) in Unixtime
        /// </summary>
        [JsonProperty("updated_time")]
        public int? UpdatedTime_ { get; set; }

        /// <summary>
        /// URL of the preview image with 130 px in width
        /// </summary>
        [JsonProperty("photo_130")]
        public string Photo130_ { get; set; }

        /// <summary>
        /// Duration in seconds
        /// </summary>
        [JsonProperty("duration")]
        public int? Duration { get; set; }

        /// <summary>
        /// URL of the preview image with 640 px in width
        /// </summary>
        [JsonProperty("photo_640")]
        public string Photo640_ { get; set; }

        /// <summary>
        /// Element title
        /// </summary>
        [JsonProperty("title")]
        public string Title { get; set; }

    }
}
