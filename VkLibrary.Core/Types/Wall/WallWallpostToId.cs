using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace VkLibrary.Core.Objects
{
    public class WallWallpostToId
    {
        [JsonProperty("attachments")]
        public WallWallpostAttachment[] Attachments { get; set; }
        [JsonProperty("comments")]
        public BaseCommentsInfo Comments { get; set; }

        ///<summary>
        /// ID of the source post owner
        ///</summary>
        [JsonProperty("copy_owner_id")]
        public int CopyOwnerId { get; set; }

        ///<summary>
        /// ID of the source post
        ///</summary>
        [JsonProperty("copy_post_id")]
        public int CopyPostId { get; set; }

        ///<summary>
        /// Date of publishing in Unixtime
        ///</summary>
        [JsonProperty("date")]
        public int Date { get; set; }

        ///<summary>
        /// Post author ID
        ///</summary>
        [JsonProperty("from_id")]
        public int FromId { get; set; }
        [JsonProperty("geo")]
        public WallGeo Geo { get; set; }

        ///<summary>
        /// Post ID
        ///</summary>
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("likes")]
        public BaseLikesInfo Likes { get; set; }

        ///<summary>
        /// wall post ID (if comment)
        ///</summary>
        [JsonProperty("post_id")]
        public int PostId { get; set; }
        [JsonProperty("post_source")]
        public WallPostSource PostSource { get; set; }
        [JsonProperty("post_type")]
        public WallPostType PostType { get; set; }
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
        /// Wall owner's ID
        ///</summary>
        [JsonProperty("to_id")]
        public int ToId { get; set; }
    }
}