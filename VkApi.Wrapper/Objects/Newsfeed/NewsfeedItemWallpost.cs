using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace VkApi.Wrapper.Objects
{
    public class NewsfeedItemWallpost : NewsfeedItemBase
    {
        [JsonProperty("activity")]
        public NewsfeedEventActivity Activity { get; set; }
        [JsonProperty("attachments")]
        public WallWallpostAttachment[] Attachments { get; set; }
        [JsonProperty("comments")]
        public BaseCommentsInfo Comments { get; set; }
        [JsonProperty("copy_history")]
        public WallWallpost[] CopyHistory { get; set; }
        [JsonProperty("feedback")]
        public NewsfeedItemWallpostFeedback Feedback { get; set; }
        [JsonProperty("geo")]
        public BaseGeo Geo { get; set; }

        ///<summary>
        /// Information whether the post in favorites list
        ///</summary>
        [JsonProperty("is_favorite")]
        public Boolean IsFavorite { get; set; }
        [JsonProperty("likes")]
        public BaseLikesInfo Likes { get; set; }

        ///<summary>
        /// Information whether the post is marked as ads
        ///</summary>
        [JsonProperty("marked_as_ads")]
        public int MarkedAsAds { get; set; }

        ///<summary>
        /// Post ID
        ///</summary>
        [JsonProperty("post_id")]
        public int PostId { get; set; }
        [JsonProperty("post_source")]
        public WallPostSource PostSource { get; set; }
        [JsonProperty("post_type")]
        public NewsfeedItemWallpostType PostType { get; set; }
        [JsonProperty("reposts")]
        public BaseRepostsInfo Reposts { get; set; }

        ///<summary>
        /// Post signer ID
        ///</summary>
        [JsonProperty("signer_id")]
        public int SignerId { get; set; }

        ///<summary>
        /// Post text
        ///</summary>
        [JsonProperty("text")]
        public String Text { get; set; }

        ///<summary>
        /// Count of views
        ///</summary>
        [JsonProperty("views")]
        public WallViews Views { get; set; }
    }
}