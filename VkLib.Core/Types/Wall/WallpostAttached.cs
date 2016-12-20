using System;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace VkLib.Types.Wall 
{
    public class WallpostAttached
    {
        /// <summary>
        /// Property
        /// </summary>
        [JsonProperty("geo")]
        public VkLib.Types.Base.Geo Geo { get; set; }

        /// <summary>
        /// Post signer ID
        /// </summary>
        [JsonProperty("signer_id")]
        public int? SignerId_ { get; set; }

        /// <summary>
        /// Source post owner's ID
        /// </summary>
        [JsonProperty("copy_owner_id")]
        public int? CopyOwnerId { get; set; }

        /// <summary>
        /// Post text
        /// </summary>
        [JsonProperty("text")]
        public string Text { get; set; }

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
        /// Property
        /// </summary>
        [JsonProperty("post_source")]
        public VkLib.Types.Wall.PostSource PostSource_ { get; set; }

        /// <summary>
        /// Information whether current user can delete the post
        /// </summary>
        [JsonProperty("can_delete")]
        public int? CanDelete_ { get; set; }

        /// <summary>
        /// Property
        /// </summary>
        [JsonProperty("likes")]
        public VkLib.Types.Base.LikesInfo Likes { get; set; }

        /// <summary>
        /// Property
        /// </summary>
        [JsonProperty("post_type")]
        public string PostType_ { get; set; }

        /// <summary>
        /// Property
        /// </summary>
        [JsonProperty("reposts")]
        public VkLib.Types.Base.RepostsInfo Reposts { get; set; }

        /// <summary>
        /// Post addresse
        /// </summary>
        [JsonProperty("to_id")]
        public int? ToId_ { get; set; }

        /// <summary>
        /// Post ID
        /// </summary>
        [JsonProperty("id")]
        public int? Id { get; set; }

        /// <summary>
        /// Source post ID
        /// </summary>
        [JsonProperty("copy_post_id")]
        public int? CopyPostId { get; set; }

        /// <summary>
        /// Post author ID
        /// </summary>
        [JsonProperty("from_id")]
        public int? FromId_ { get; set; }

        /// <summary>
        /// Repost comment
        /// </summary>
        [JsonProperty("copy_text")]
        public string CopyText_ { get; set; }

        /// <summary>
        /// Date of publishing in Unixtime
        /// </summary>
        [JsonProperty("date")]
        public int? Date { get; set; }

    }
}
