using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace VkLibrary.Core.Objects
{
    public class NewsfeedItemWallpost
    {
        [JsonProperty("activity")]
        public NewsfeedEventActivity Activity { get; set; }
        [JsonProperty("attachments")]
        public WallWallpostAttachment[] Attachments { get; set; }
        [JsonProperty("comments")]
        public BaseCommentsInfo Comments { get; set; }
        [JsonProperty("copy_history")]
        public WallWallpost[] CopyHistory { get; set; }
        [JsonProperty("geo")]
        public BaseGeo Geo { get; set; }
        [JsonProperty("likes")]
        public BaseLikesInfo Likes { get; set; }

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
        /// Post text
        ///</summary>
        [JsonProperty("text")]
        public String Text { get; set; }
    }
}