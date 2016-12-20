using System;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace VkLib.Types.Video 
{
    public class VideoFull
    {
        /// <summary>
        /// Information whether current user can comment the video
        /// </summary>
        [JsonProperty("can_comment")]
        public int? CanComment { get; set; }

        /// <summary>
        /// Video ID
        /// </summary>
        [JsonProperty("id")]
        public int? Id { get; set; }

        /// <summary>
        /// URL of the preview image with 130 px in width
        /// </summary>
        [JsonProperty("photo_130")]
        public string Photo130 { get; set; }

        /// <summary>
        /// Date when the video has been added in Unixtime
        /// </summary>
        [JsonProperty("adding_date")]
        public int? AddingDate { get; set; }

        /// <summary>
        /// Information whether current user can add the video
        /// </summary>
        [JsonProperty("can_add")]
        public int? CanAdd { get; set; }

        /// <summary>
        /// Returns if the video is live translation
        /// </summary>
        [JsonProperty("live")]
        public string Live { get; set; }

        /// <summary>
        /// URL of the page with a player that can be used to play the video in the browser.
        /// </summary>
        [JsonProperty("player")]
        public string Player { get; set; }

        /// <summary>
        /// Number of comments
        /// </summary>
        [JsonProperty("comments")]
        public int? Comments { get; set; }

        /// <summary>
        /// Information whether current user can edit the video
        /// </summary>
        [JsonProperty("can_edit")]
        public int? CanEdit { get; set; }

        /// <summary>
        /// Property
        /// </summary>
        [JsonProperty("privacy_comment")]
        public IEnumerable<string> PrivacyComment { get; set; }

        /// <summary>
        /// Information whether the video is repeated
        /// </summary>
        [JsonProperty("repeat")]
        public int? Repeat { get; set; }

        /// <summary>
        /// Property
        /// </summary>
        [JsonProperty("privacy_view")]
        public IEnumerable<string> PrivacyView { get; set; }

        /// <summary>
        /// Information whether current user can comment the video
        /// </summary>
        [JsonProperty("can_repost")]
        public int? CanRepost { get; set; }

        /// <summary>
        /// Returns if the video is processing
        /// </summary>
        [JsonProperty("processing")]
        public string Processing { get; set; }

        /// <summary>
        /// Property
        /// </summary>
        [JsonProperty("likes")]
        public VkLib.Types.Base.Likes Likes { get; set; }

        /// <summary>
        /// Video duration in seconds
        /// </summary>
        [JsonProperty("duration")]
        public int? Duration { get; set; }

        /// <summary>
        /// Video description
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        /// Video access key
        /// </summary>
        [JsonProperty("access_key")]
        public string AccessKey { get; set; }

        /// <summary>
        /// Video title
        /// </summary>
        [JsonProperty("title")]
        public string Title { get; set; }

        /// <summary>
        /// URL of the preview image with 800 px in width
        /// </summary>
        [JsonProperty("photo_800")]
        public string Photo800 { get; set; }

        /// <summary>
        /// Number of views
        /// </summary>
        [JsonProperty("views")]
        public int? Views { get; set; }

        /// <summary>
        /// URL of the preview image with 320 px in width
        /// </summary>
        [JsonProperty("photo_320")]
        public string Photo320 { get; set; }

        /// <summary>
        /// Video owner ID
        /// </summary>
        [JsonProperty("owner_id")]
        public int? OwnerId { get; set; }

        /// <summary>
        /// Date when video has been uploaded in Unixtime
        /// </summary>
        [JsonProperty("date")]
        public int? Date { get; set; }

        /// <summary>
        /// Property
        /// </summary>
        [JsonProperty("files")]
        public VkLib.Types.Video.VideoFiles Files { get; set; }

    }
}
