using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace VkApi.Wrapper.Objects
{
    public class AdsPromotedPostReach
    {
        ///<summary>
        /// Hides amount
        ///</summary>
        [JsonProperty("hide")]
        public int Hide { get; set; }

        ///<summary>
        /// Object ID from 'ids' parameter
        ///</summary>
        [JsonProperty("id")]
        public int Id { get; set; }

        ///<summary>
        /// Community joins
        ///</summary>
        [JsonProperty("join_group")]
        public int JoinGroup { get; set; }

        ///<summary>
        /// Link clicks
        ///</summary>
        [JsonProperty("links")]
        public int Links { get; set; }

        ///<summary>
        /// Subscribers reach
        ///</summary>
        [JsonProperty("reach_subscribers")]
        public int ReachSubscribers { get; set; }

        ///<summary>
        /// Total reach
        ///</summary>
        [JsonProperty("reach_total")]
        public int ReachTotal { get; set; }

        ///<summary>
        /// Reports amount
        ///</summary>
        [JsonProperty("report")]
        public int Report { get; set; }

        ///<summary>
        /// Community clicks
        ///</summary>
        [JsonProperty("to_group")]
        public int ToGroup { get; set; }

        ///<summary>
        /// 'Unsubscribe' events amount
        ///</summary>
        [JsonProperty("unsubscribe")]
        public int Unsubscribe { get; set; }

        ///<summary>
        /// Video views for 100 percent
        ///</summary>
        [JsonProperty("video_views_100p")]
        public int VideoViews100p { get; set; }

        ///<summary>
        /// Video views for 25 percent
        ///</summary>
        [JsonProperty("video_views_25p")]
        public int VideoViews25p { get; set; }

        ///<summary>
        /// Video views for 3 seconds
        ///</summary>
        [JsonProperty("video_views_3s")]
        public int VideoViews3s { get; set; }

        ///<summary>
        /// Video views for 50 percent
        ///</summary>
        [JsonProperty("video_views_50p")]
        public int VideoViews50p { get; set; }

        ///<summary>
        /// Video views for 75 percent
        ///</summary>
        [JsonProperty("video_views_75p")]
        public int VideoViews75p { get; set; }

        ///<summary>
        /// Video starts
        ///</summary>
        [JsonProperty("video_views_start")]
        public int VideoViewsStart { get; set; }
    }
}