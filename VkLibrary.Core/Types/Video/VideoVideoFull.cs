using System;
using Newtonsoft.Json;
using VkApi.Wrapper.Types.Base;

namespace VkApi.Wrapper.Types.Video
{
    public class VideoVideoFull
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
        /// Information whether current user can add the video to favourites
        ///</summary>
        [JsonProperty("can_add_to_faves")]
        public int CanAddToFaves { get; set; }

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
        /// Information whether current user can comment the video
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
        /// URL of the first frame for the corresponding width.
        ///</summary>
        [JsonProperty("first_frame_640")]
        public String FirstFrame640 { get; set; }

        ///<summary>
        /// URL of the first frame for the corresponding width.
        ///</summary>
        [JsonProperty("first_frame_1280")]
        public String FirstFrame1280 { get; set; }

        ///<summary>
        /// Video ID
        ///</summary>
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("image")]
        public VideoVideoImage[] Image { get; set; }
        [JsonProperty("likes")]
        public BaseLikes Likes { get; set; }

        ///<summary>
        /// Returns if the video is live translation
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
        /// Information whether the video is repeated
        ///</summary>
        [JsonProperty("repeat")]
        public int Repeat { get; set; }

        ///<summary>
        /// Video title
        ///</summary>
        [JsonProperty("title")]
        public String Title { get; set; }

        ///<summary>
        /// Number of views
        ///</summary>
        [JsonProperty("views")]
        public int Views { get; set; }
    }
}