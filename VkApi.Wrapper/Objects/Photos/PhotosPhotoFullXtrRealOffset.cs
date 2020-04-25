using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace VkApi.Wrapper.Objects
{
    public class PhotosPhotoFullXtrRealOffset
    {
        ///<summary>
        /// Access key for the photo
        ///</summary>
        [JsonProperty("access_key")]
        public String AccessKey { get; set; }

        ///<summary>
        /// Album ID
        ///</summary>
        [JsonProperty("album_id")]
        public int AlbumId { get; set; }
        [JsonProperty("can_comment")]
        public int CanComment { get; set; }
        [JsonProperty("comments")]
        public BaseObjectCount Comments { get; set; }

        ///<summary>
        /// Date when uploaded
        ///</summary>
        [JsonProperty("date")]
        public int Date { get; set; }

        ///<summary>
        /// Original photo height
        ///</summary>
        [JsonProperty("height")]
        public int Height { get; set; }

        ///<summary>
        /// Returns if the photo is hidden above the wall
        ///</summary>
        [JsonProperty("hidden")]
        public BasePropertyExists Hidden { get; set; }

        ///<summary>
        /// Photo ID
        ///</summary>
        [JsonProperty("id")]
        public int Id { get; set; }

        ///<summary>
        /// Latitude
        ///</summary>
        [JsonProperty("lat")]
        public double Lat { get; set; }
        [JsonProperty("likes")]
        public BaseLikes Likes { get; set; }

        ///<summary>
        /// Longitude
        ///</summary>
        [JsonProperty("long")]
        public double Long { get; set; }

        ///<summary>
        /// Photo owner's ID
        ///</summary>
        [JsonProperty("owner_id")]
        public int OwnerId { get; set; }

        ///<summary>
        /// URL of image with 1280 px width
        ///</summary>
        [JsonProperty("photo_1280")]
        public String Photo1280 { get; set; }

        ///<summary>
        /// URL of image with 130 px width
        ///</summary>
        [JsonProperty("photo_130")]
        public String Photo130 { get; set; }

        ///<summary>
        /// URL of image with 2560 px width
        ///</summary>
        [JsonProperty("photo_2560")]
        public String Photo2560 { get; set; }

        ///<summary>
        /// URL of image with 604 px width
        ///</summary>
        [JsonProperty("photo_604")]
        public String Photo604 { get; set; }

        ///<summary>
        /// URL of image with 75 px width
        ///</summary>
        [JsonProperty("photo_75")]
        public String Photo75 { get; set; }

        ///<summary>
        /// URL of image with 807 px width
        ///</summary>
        [JsonProperty("photo_807")]
        public String Photo807 { get; set; }

        ///<summary>
        /// Post ID
        ///</summary>
        [JsonProperty("post_id")]
        public int PostId { get; set; }

        ///<summary>
        /// Real position of the photo
        ///</summary>
        [JsonProperty("real_offset")]
        public int RealOffset { get; set; }
        [JsonProperty("reposts")]
        public BaseObjectCount Reposts { get; set; }
        [JsonProperty("sizes")]
        public PhotosPhotoSizes[] Sizes { get; set; }
        [JsonProperty("tags")]
        public BaseObjectCount Tags { get; set; }

        ///<summary>
        /// Photo caption
        ///</summary>
        [JsonProperty("text")]
        public String Text { get; set; }

        ///<summary>
        /// ID of the user who have uploaded the photo
        ///</summary>
        [JsonProperty("user_id")]
        public int UserId { get; set; }

        ///<summary>
        /// Original photo width
        ///</summary>
        [JsonProperty("width")]
        public int Width { get; set; }
    }
}