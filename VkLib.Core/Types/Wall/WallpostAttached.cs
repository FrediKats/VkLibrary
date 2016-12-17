using System;
using Newtonsoft.Json;

namespace VkLib.Types.Wall 
{
    public class WallpostAttached
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
        /// Post addresse
        /// </summary>
        [JsonProperty("to_id")]
        public int? ToId { get; set; }

        /// <summary>
        /// Property
        /// </summary>
        [JsonProperty("post_type")]
        public PostType PostType { get; set; }

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
        /// Source post ID
        /// </summary>
        [JsonProperty("copy_post_id")]
        public int? CopyPostId { get; set; }

        /// <summary>
        /// Source post owner's ID
        /// </summary>
        [JsonProperty("copy_owner_id")]
        public int? CopyOwnerId { get; set; }

        /// <summary>
        /// Date of publishing in Unixtime
        /// </summary>
        [JsonProperty("date")]
        public int? Date { get; set; }

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

        /// <summary>
        /// Repost comment
        /// </summary>
        [JsonProperty("copy_text")]
        public string CopyText { get; set; }

        /// <summary>
        /// Information whether current user can delete the post
        /// </summary>
        [JsonProperty("can_delete")]
        public int? CanDelete { get; set; }

    }
}
