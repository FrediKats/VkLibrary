using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace VkApi.Wrapper.Objects
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
        /// Information whether current user can repost the video
        ///</summary>
        [JsonProperty("can_repost")]
        public int CanRepost { get; set; }

        ///<summary>
        /// Information whether current user can subscribe to author of the video
        ///</summary>
        [JsonProperty("can_subscribe")]
        public int CanSubscribe { get; set; }

        ///<summary>
        /// Information whether current user can add the video to favourites
        ///</summary>
        [JsonProperty("can_add_to_faves")]
        public int CanAddToFaves { get; set; }

        ///<summary>
        /// Information whether current user can add the video
        ///</summary>
        [JsonProperty("can_add")]
        public int CanAdd { get; set; }

        ///<summary>
        /// Information whether current user can attach action button to the video
        ///</summary>
        [JsonProperty("can_attach_link")]
        public int CanAttachLink { get; set; }

        ///<summary>
        /// 1 if video is private
        ///</summary>
        [JsonProperty("is_private")]
        public int IsPrivate { get; set; }

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
        [JsonProperty("image")]
        public VideoVideoImage[] Image { get; set; }
        [JsonProperty("first_frame")]
        public VideoVideoImage[] FirstFrame { get; set; }

        ///<summary>
        /// Video width
        ///</summary>
        [JsonProperty("width")]
        public int Width { get; set; }

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

        ///<summary>
        /// Video owner ID
        ///</summary>
        [JsonProperty("owner_id")]
        public int OwnerId { get; set; }

        ///<summary>
        /// Id of the user who uploaded the video if it was uploaded to a group by member
        ///</summary>
        [JsonProperty("user_id")]
        public int UserId { get; set; }

        ///<summary>
        /// Video title
        ///</summary>
        [JsonProperty("title")]
        public String Title { get; set; }

        ///<summary>
        /// Whether video is added to bookmarks
        ///</summary>
        [JsonProperty("is_favorite")]
        public Boolean IsFavorite { get; set; }

        ///<summary>
        /// Video embed URL
        ///</summary>
        [JsonProperty("player")]
        public String Player { get; set; }

        ///<summary>
        /// Returns if the video is processing
        ///</summary>
        [JsonProperty("processing")]
        public BasePropertyExists Processing { get; set; }

        ///<summary>
        /// 1 if  video is being converted
        ///</summary>
        [JsonProperty("converting")]
        public int Converting { get; set; }
        [JsonProperty("restriction")]
        public MediaRestriction Restriction { get; set; }

        ///<summary>
        /// 1 if video is added to user's albums
        ///</summary>
        [JsonProperty("added")]
        public int Added { get; set; }

        ///<summary>
        /// 1 if user is subscribed to author of the video
        ///</summary>
        [JsonProperty("is_subscribed")]
        public int IsSubscribed { get; set; }
        [JsonProperty("track_code")]
        public String TrackCode { get; set; }

        ///<summary>
        /// Information whether the video is repeated
        ///</summary>
        [JsonProperty("repeat")]
        public BasePropertyExists Repeat { get; set; }
        [JsonProperty("type")]
        public String Type { get; set; }

        ///<summary>
        /// Number of views
        ///</summary>
        [JsonProperty("views")]
        public int Views { get; set; }

        ///<summary>
        /// If video is external, number of views on vk
        ///</summary>
        [JsonProperty("local_views")]
        public int LocalViews { get; set; }

        ///<summary>
        /// Restriction code
        ///</summary>
        [JsonProperty("content_restricted")]
        public int ContentRestricted { get; set; }

        ///<summary>
        /// Restriction text
        ///</summary>
        [JsonProperty("content_restricted_message")]
        public String ContentRestrictedMessage { get; set; }

        ///<summary>
        /// Live donations balance
        ///</summary>
        [JsonProperty("balance")]
        public int Balance { get; set; }

        ///<summary>
        /// Live stream status
        ///</summary>
        [JsonProperty("live_status")]
        public String LiveStatus { get; set; }

        ///<summary>
        /// 1 if the video is a live stream
        ///</summary>
        [JsonProperty("live")]
        public BasePropertyExists Live { get; set; }

        ///<summary>
        /// 1 if the video is an upcoming stream
        ///</summary>
        [JsonProperty("upcoming")]
        public BasePropertyExists Upcoming { get; set; }

        ///<summary>
        /// Number of spectators of the stream
        ///</summary>
        [JsonProperty("spectators")]
        public int Spectators { get; set; }

        ///<summary>
        /// External platform
        ///</summary>
        [JsonProperty("platform")]
        public String Platform { get; set; }
        [JsonProperty("likes")]
        public BaseLikes Likes { get; set; }
        [JsonProperty("reposts")]
        public BaseRepostsInfo Reposts { get; set; }
    }
}