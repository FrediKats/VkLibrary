using System;
using Newtonsoft.Json;
using VkApi.Wrapper.Types.Base;

namespace VkApi.Wrapper.Types.Video
{
    public class VideoVideo
    {
        ///<summary>
        /// Video access key
        ///</summary>
        [JsonProperty("access_key")]
        public String AccessKey { get; set; }

        ///<summary>
        /// Date when the video has been added in Unixtime
        ///</summary>
        [JsonProperty("adding_date")]
        public int AddingDate { get; set; }

        ///<summary>
        /// Information whether current user can add the video
        ///</summary>
        [JsonProperty("can_add")]
        public int CanAdd { get; set; }

        ///<summary>
        /// Information whether current user can comment the video
        ///</summary>
        [JsonProperty("can_comment")]
        public int CanComment { get; set; }

        ///<summary>
        /// Information whether current user can edit the video
        ///</summary>
        [JsonProperty("can_edit")]
        public int CanEdit { get; set; }

        ///<summary>
        /// Information whether current user can like the video
        ///</summary>
        [JsonProperty("can_like")]
        public int CanLike { get; set; }

        ///<summary>
        /// Information whether current user can repost this video
        ///</summary>
        [JsonProperty("can_repost")]
        public int CanRepost { get; set; }

        ///<summary>
        /// Number of comments
        ///</summary>
        [JsonProperty("comments")]
        public int Comments { get; set; }

        ///<summary>
        /// Date when video has been uploaded in Unixtime
        ///</summary>
        [JsonProperty("date")]
        public int Date { get; set; }

        ///<summary>
        /// Video description
        ///</summary>
        [JsonProperty("description")]
        public String Description { get; set; }

        ///<summary>
        /// Video duration in seconds
        ///</summary>
        [JsonProperty("duration")]
        public int Duration { get; set; }
        [JsonProperty("files")]
        public VideoVideoFiles Files { get; set; }
        [JsonProperty("first_frame")]
        public VideoVideoImage[] FirstFrame { get; set; }

        ///<summary>
        /// Video height
        ///</summary>
        [JsonProperty("height")]
        public int Height { get; set; }

        ///<summary>
        /// Video ID
        ///</summary>
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("image")]
        public VideoVideoImage[] Image { get; set; }
        [JsonProperty("is_favorite")]
        public Boolean IsFavorite { get; set; }

        ///<summary>
        /// Returns if the video is a live stream
        ///</summary>
        [JsonProperty("live")]
        public BasePropertyExists Live { get; set; }

        ///<summary>
        /// Video owner ID
        ///</summary>
        [JsonProperty("owner_id")]
        public int OwnerId { get; set; }

        ///<summary>
        /// URL of the page with a player that can be used to play the video in the browser.
        ///</summary>
        [JsonProperty("player")]
        public String Player { get; set; }

        ///<summary>
        /// Returns if the video is processing
        ///</summary>
        [JsonProperty("processing")]
        public BasePropertyExists Processing { get; set; }

        ///<summary>
        /// Video title
        ///</summary>
        [JsonProperty("title")]
        public String Title { get; set; }
        [JsonProperty("type")]
        public String Type { get; set; }

        ///<summary>
        /// Number of views
        ///</summary>
        [JsonProperty("views")]
        public int Views { get; set; }

        ///<summary>
        /// Video width
        ///</summary>
        [JsonProperty("width")]
        public int Width { get; set; }
    }
}