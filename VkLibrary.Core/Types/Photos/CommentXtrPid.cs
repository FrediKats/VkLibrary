using System.Collections.Generic;
using Newtonsoft.Json;
using VkLibrary.Core.Types.Base;
using VkLibrary.Core.Types.Wall;

namespace VkLibrary.Core.Types.Photos
{
    /// <summary>
    /// API CommentXtrPid object.
    /// </summary>
    public class CommentXtrPid
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
        public IEnumerable<CommentAttachment> Attachments { get; set; }

        /// <summary>
        /// Date when the comment has been added in Unixtime
        /// </summary>
        [JsonProperty("date")]
        public int? Date { get; set; }

        /// <summary>
        /// Comment ID
        /// </summary>
        [JsonProperty("id")]
        public int? Id { get; set; }

        /// <summary>
        /// Photo ID
        /// </summary>
        [JsonProperty("pid")]
        public int? Pid { get; set; }

        /// <summary>
        /// Replied user ID
        /// </summary>
        [JsonProperty("reply_to_user")]
        public int? ReplyToUser { get; set; }

        /// <summary>
        /// Author ID
        /// </summary>
        [JsonProperty("from_id")]
        public int? FromId { get; set; }

        /// <summary>
        /// Property
        /// </summary>
        [JsonProperty("likes")]
        public LikesInfo Likes { get; set; }

        /// <summary>
        /// Comment text
        /// </summary>
        [JsonProperty("text")]
        public string Text { get; set; }
    }
}