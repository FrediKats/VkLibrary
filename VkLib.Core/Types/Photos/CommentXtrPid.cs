using System;
using Newtonsoft.Json;

namespace VkLib.Types.Photos 
{
    public class CommentXtrPid
    {
        /// <summary>
        /// Photo ID
        /// </summary>
        [JsonProperty("pid")]
        public int? Pid { get; set; }

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
        /// Date when the comment has been added in Unixtime
        /// </summary>
        [JsonProperty("date")]
        public int? Date { get; set; }

        /// <summary>
        /// Author ID
        /// </summary>
        [JsonProperty("from_id")]
        public int? FromId { get; set; }

        /// <summary>
        /// Comment text
        /// </summary>
        [JsonProperty("text")]
        public string Text { get; set; }

        /// <summary>
        /// Property
        /// </summary>
        [JsonProperty("attachments")]
        public IEnumerable<CommentAttachment> Attachments { get; set; }

        /// <summary>
        /// Property
        /// </summary>
        [JsonProperty("likes")]
        public LikesInfo Likes { get; set; }

        /// <summary>
        /// Replied comment ID
        /// </summary>
        [JsonProperty("reply_to_comment")]
        public int? ReplyToComment { get; set; }

    }
}
