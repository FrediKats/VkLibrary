using System;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace VkLib.Types.Wall 
{
    public class WallComment
    {
        /// <summary>
        /// Replied comment ID
        /// </summary>
        [JsonProperty("reply_to_comment")]
        public int? ReplyToComment { get; set; }

        /// <summary>
        /// Property
        /// </summary>
        [JsonProperty("attachments")]
        public IEnumerable<VkLib.Types.Wall.CommentAttachment> Attachments { get; set; }

        /// <summary>
        /// Date when the comment has been added in Unixtime
        /// </summary>
        [JsonProperty("date")]
        public double? Date { get; set; }

        /// <summary>
        /// Comment ID
        /// </summary>
        [JsonProperty("id")]
        public int? Id { get; set; }

        /// <summary>
        /// Replied user ID
        /// </summary>
        [JsonProperty("reply_to_user")]
        public int? ReplyToUser { get; set; }

        /// <summary>
        /// Real position of the comment
        /// </summary>
        [JsonProperty("real_offset")]
        public int? RealOffset { get; set; }

        /// <summary>
        /// Author ID
        /// </summary>
        [JsonProperty("from_id")]
        public int? FromId { get; set; }

        /// <summary>
        /// Property
        /// </summary>
        [JsonProperty("likes")]
        public VkLib.Types.Base.LikesInfo Likes { get; set; }

        /// <summary>
        /// Comment text
        /// </summary>
        [JsonProperty("text")]
        public string Text { get; set; }

    }
}
