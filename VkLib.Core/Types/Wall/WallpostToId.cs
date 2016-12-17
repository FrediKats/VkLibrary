using System;
using Newtonsoft.Json;

namespace VkLib.Types.Wall 
{
    public class WallpostToId
    {
        /// <summary>
        /// Post author ID
        /// </summary>
        [JsonProperty("from_id")]
        public int? FromId { get; set; }

        /// <summary>
        /// Post signer ID
        /// </summary>
        [JsonProperty("signer_id")]
        public int? SignerId { get; set; }

        /// <summary>
        /// Wall owner's ID
        /// </summary>
        [JsonProperty("to_id")]
        public int? ToId { get; set; }

        /// <summary>
        /// Date of publishing in Unixtime
        /// </summary>
        [JsonProperty("date")]
        public int? Date { get; set; }

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
        /// Property
        /// </summary>
        [JsonProperty("likes")]
        public LikesInfo Likes { get; set; }

        /// <summary>
        /// Property
        /// </summary>
        [JsonProperty("comments")]
        public CommentsInfo Comments { get; set; }

        /// <summary>
        /// Post ID
        /// </summary>
        [JsonProperty("id")]
        public int? Id { get; set; }

        /// <summary>
        /// Property
        /// </summary>
        [JsonProperty("post_source")]
        public PostSource PostSource { get; set; }

        /// <summary>
        /// ID of the source post
        /// </summary>
        [JsonProperty("copy_post_id")]
        public int? CopyPostId { get; set; }

        /// <summary>
        /// ID of the source post owner
        /// </summary>
        [JsonProperty("copy_owner_id")]
        public int? CopyOwnerId { get; set; }

        /// <summary>
        /// Property
        /// </summary>
        [JsonProperty("post_type")]
        public PostType PostType { get; set; }

        /// <summary>
        /// Property
        /// </summary>
        [JsonProperty("reposts")]
        public RepostsInfo Reposts { get; set; }

        /// <summary>
        /// Property
        /// </summary>
        [JsonProperty("attachments")]
        public IEnumerable<WallpostAttachment> Attachments { get; set; }

        /// <summary>
        /// Property
        /// </summary>
        [JsonProperty("geo")]
        public Geo Geo { get; set; }

    }
}
