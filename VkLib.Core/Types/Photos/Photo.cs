using System;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace VkLib.Types.Photos 
{
    public class Photo
    {
        /// <summary>
        /// Date when uploaded
        /// </summary>
        [JsonProperty("date")]
        public int? Date_ { get; set; }

        /// <summary>
        /// URL of image with 75 px width
        /// </summary>
        [JsonProperty("photo_75")]
        public string Photo75 { get; set; }

        /// <summary>
        /// Post ID
        /// </summary>
        [JsonProperty("post_id")]
        public int? PostId { get; set; }

        /// <summary>
        /// Photo caption
        /// </summary>
        [JsonProperty("text")]
        public string Text_ { get; set; }

        /// <summary>
        /// Photo owner's ID
        /// </summary>
        [JsonProperty("owner_id")]
        public int? OwnerId { get; set; }

        /// <summary>
        /// URL of image with 807 px width
        /// </summary>
        [JsonProperty("photo_807")]
        public string Photo807 { get; set; }

        /// <summary>
        /// Album ID
        /// </summary>
        [JsonProperty("album_id")]
        public int? AlbumId { get; set; }

        /// <summary>
        /// Original photo height
        /// </summary>
        [JsonProperty("height")]
        public int? Height_ { get; set; }

        /// <summary>
        /// Property
        /// </summary>
        [JsonProperty("sizes")]
        public IEnumerable<VkLib.Types.Photos.PhotoSizes> Sizes_ { get; set; }

        /// <summary>
        /// Access key for the photo
        /// </summary>
        [JsonProperty("access_key")]
        public string AccessKey { get; set; }

        /// <summary>
        /// URL of image with 1280 px width
        /// </summary>
        [JsonProperty("photo_1280")]
        public string Photo1280 { get; set; }

        /// <summary>
        /// Original photo width
        /// </summary>
        [JsonProperty("width")]
        public int? Width_ { get; set; }

        /// <summary>
        /// Photo ID
        /// </summary>
        [JsonProperty("id")]
        public int? Id_ { get; set; }

        /// <summary>
        /// Longitude
        /// </summary>
        [JsonProperty("long")]
        public uint? Long_ { get; set; }

        /// <summary>
        /// URL of image with 604 px width
        /// </summary>
        [JsonProperty("photo_604")]
        public string Photo604 { get; set; }

        /// <summary>
        /// URL of image with 130 px width
        /// </summary>
        [JsonProperty("photo_130")]
        public string Photo130 { get; set; }

        /// <summary>
        /// ID of the user who have uploaded the photo
        /// </summary>
        [JsonProperty("user_id")]
        public int? UserId { get; set; }

        /// <summary>
        /// Latitude
        /// </summary>
        [JsonProperty("lat")]
        public uint? Lat_ { get; set; }

    }
}
