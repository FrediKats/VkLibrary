using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace VkApi.Wrapper.Objects
{
    public class NewsfeedItemDigest
    {
        [JsonProperty("button_text")]
        public String ButtonText { get; set; }

        ///<summary>
        /// id of feed in digest
        ///</summary>
        [JsonProperty("feed_id")]
        public String FeedId { get; set; }
        [JsonProperty("items")]
        public WallWallpost[] Items { get; set; }
        [JsonProperty("main_post_ids")]
        public String[] MainPostIds { get; set; }

        ///<summary>
        /// type of digest
        ///</summary>
        [JsonProperty("template")]
        public String Template { get; set; }
        [JsonProperty("title")]
        public String Title { get; set; }
        [JsonProperty("track_code")]
        public String TrackCode { get; set; }
    }
}