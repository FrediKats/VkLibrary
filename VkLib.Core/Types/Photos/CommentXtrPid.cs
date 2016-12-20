using System;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace VkLib.Types.Photos 
{
    public class CommentXtrPid
    {
        /// <summary>
        /// Replied comment ID
        /// </summary>
        [JsonProperty("reply_to_comment")]
        public int? ReplyToComment_ { get; set; }

        /// <summary>
        /// Comment ID
        /// </summary>
        [JsonProperty("id")]
        public int? Id { get; set; }

        /// <summary>
        /// Comment text
        /// </summary>
        [JsonProperty("text")]
        public string Text { get; set; }

        /// <summary>
        /// Author ID
        /// </summary>
        [JsonProperty("from_id")]
        public int? FromId { get; set; }

        /// <summary>
        /// Property
        /// </summary>
        [JsonProperty("attachments")]
        public IEnumerable<VkLib.Types.Wall.CommentAttachment> Attachments { get; set; }

        /// <summary>
        /// Photo ID
        /// </summary>
        [JsonProperty("pid")]
        public int? Pid { get; set; }

        /// <summary>
        /// Replied user ID
        /// </summary>
        [JsonProperty("reply_to_user")]
        public int? ReplyToUser_ { get; set; }

        /// <summary>
        /// Date when the comment has been added in Unixtime
        /// </summary>
        [JsonProperty("date")]
        public int? Date { get; set; }

        /// <summary>
        /// Property
        /// </summary>
        [JsonProperty("likes")]
        public VkLib.Types.Base.LikesInfo Likes { get; set; }

    }
}
