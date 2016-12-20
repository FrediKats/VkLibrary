using System;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace VkLib.Types.Photos 
{
    public class PhotoAlbumFull
    {
        /// <summary>
        /// Thumb photo ID
        /// </summary>
        [JsonProperty("thumb_id")]
        public int? ThumbId { get; set; }

        /// <summary>
        /// Information whether album comments are disabled
        /// </summary>
        [JsonProperty("comments_disabled")]
        public int? CommentsDisabled { get; set; }

        /// <summary>
        /// Date when the album has been updated last time in Unixtime
        /// </summary>
        [JsonProperty("updated")]
        public int? Updated { get; set; }

        /// <summary>
        /// Album owner's ID
        /// </summary>
        [JsonProperty("owner_id")]
        public int? OwnerId { get; set; }

        /// <summary>
        /// URL of the thumb image
        /// </summary>
        [JsonProperty("thumb_src")]
        public string ThumbSrc { get; set; }

        /// <summary>
        /// Property
        /// </summary>
        [JsonProperty("privacy_comment")]
        public IEnumerable<string> PrivacyComment { get; set; }

        /// <summary>
        /// Date when the album has been created in Unixtime
        /// </summary>
        [JsonProperty("created")]
        public int? Created { get; set; }

        /// <summary>
        /// Information whether current user can upload photo to the album
        /// </summary>
        [JsonProperty("can_upload")]
        public int? CanUpload { get; set; }

        /// <summary>
        /// Photo album description
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        /// Information whether the album thumb is last photo
        /// </summary>
        [JsonProperty("thumb_is_last")]
        public int? ThumbIsLast_ { get; set; }

        /// <summary>
        /// Information whether only community administrators can upload photos
        /// </summary>
        [JsonProperty("upload_by_admins_only")]
        public int? UploadByAdminsOnly { get; set; }

        /// <summary>
        /// Photo album ID
        /// </summary>
        [JsonProperty("id")]
        public int? Id { get; set; }

        /// <summary>
        /// Property
        /// </summary>
        [JsonProperty("sizes")]
        public IEnumerable<VkLib.Types.Photos.PhotoSizes> Sizes { get; set; }

        /// <summary>
        /// Photos number
        /// </summary>
        [JsonProperty("size")]
        public int? Size { get; set; }

        /// <summary>
        /// Photo album title
        /// </summary>
        [JsonProperty("title")]
        public string Title { get; set; }

        /// <summary>
        /// Property
        /// </summary>
        [JsonProperty("privacy_view")]
        public IEnumerable<string> PrivacyView { get; set; }

    }
}
