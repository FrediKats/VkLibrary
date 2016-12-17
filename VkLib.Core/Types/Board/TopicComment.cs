using System;
using Newtonsoft.Json;

namespace VkLib.Types.Board 
{
    public class TopicComment
    {
        /// <summary>
        /// Comment ID
        /// </summary>
        [JsonProperty("id")]
        public int? Id { get; set; }

        /// <summary>
        /// Real position of the comment
        /// </summary>
        [JsonProperty("real_offset")]
        public int? RealOffset { get; set; }

        /// <summary>
        /// Date when the comment has been added in Unixtime
        /// </summary>
        [JsonProperty("date")]
        public int? Date { get; set; }

        /// <summary>
        /// Property
        /// </summary>
        [JsonProperty("attachments")]
        public IEnumerable<CommentAttachment> Attachments { get; set; }

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

    }
}
