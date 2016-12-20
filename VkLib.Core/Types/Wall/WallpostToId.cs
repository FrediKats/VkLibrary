using System;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace VkLib.Types.Wall 
{
    public class WallpostToId
    {
        /// <summary>
        /// Wall owner's ID
        /// </summary>
        [JsonProperty("to_id")]
        public int? ToId { get; set; }

        /// <summary>
        /// Property
        /// </summary>
        [JsonProperty("geo")]
        public VkLib.Types.Base.Geo Geo { get; set; }

        /// <summary>
        /// Property
        /// </summary>
        [JsonProperty("likes")]
        public VkLib.Types.Base.LikesInfo Likes { get; set; }

        /// <summary>
        /// Post ID
        /// </summary>
        [JsonProperty("id")]
        public int? Id { get; set; }

        /// <summary>
        /// Property
        /// </summary>
        [JsonProperty("reposts")]
        public VkLib.Types.Base.RepostsInfo Reposts { get; set; }

        /// <summary>
        /// ID of the source post owner
        /// </summary>
        [JsonProperty("copy_owner_id")]
        public int? CopyOwnerId { get; set; }

        /// <summary>
        /// Post author ID
        /// </summary>
        [JsonProperty("from_id")]
        public int? FromId { get; set; }

        /// <summary>
        /// Property
        /// </summary>
        [JsonProperty("post_type")]
        public string PostType { get; set; }

        /// <summary>
        /// Property
        /// </summary>
        [JsonProperty("attachments")]
        public IEnumerable<VkLib.Types.Wall.WallpostAttachment> Attachments { get; set; }

        /// <summary>
        /// Property
        /// </summary>
        [JsonProperty("comments")]
        public VkLib.Types.Base.CommentsInfo Comments { get; set; }

        /// <summary>
        /// Date of publishing in Unixtime
        /// </summary>
        [JsonProperty("date")]
        public int? Date { get; set; }

        /// <summary>
        /// ID of the source post
        /// </summary>
        [JsonProperty("copy_post_id")]
        public int? CopyPostId { get; set; }

        /// <summary>
        /// Property
        /// </summary>
        [JsonProperty("post_source")]
        public VkLib.Types.Wall.PostSource PostSource { get; set; }

        /// <summary>
        /// wall post ID (if comment)
        /// </summary>
        [JsonProperty("post_id")]
        public int? PostId { get; set; }

        /// <summary>
        /// Post text
        /// </summary>
        [JsonProperty("text")]
        public string Text { get; set; }

        /// <summary>
        /// Post signer ID
        /// </summary>
        [JsonProperty("signer_id")]
        public int? SignerId { get; set; }

    }
}
