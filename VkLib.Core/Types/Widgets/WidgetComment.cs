using System;
using Newtonsoft.Json;

namespace VkLib.Types.Widgets 
{
    public class WidgetComment
    {
        /// <summary>
        /// Comment author ID
        /// </summary>
        [JsonProperty("from_id")]
        public int? FromId { get; set; }

        /// <summary>
        /// Date when the comment has been added in Unixtime
        /// </summary>
        [JsonProperty("date")]
        public int? Date { get; set; }

        /// <summary>
        /// Comment text
        /// </summary>
        [JsonProperty("text")]
        public string Text { get; set; }

        /// <summary>
        /// Property
        /// </summary>
        [JsonProperty("reposts")]
        public RepostsInfo Reposts { get; set; }

        /// <summary>
        /// Property
        /// </summary>
        [JsonProperty("likes")]
        public LikesInfo Likes { get; set; }

        /// <summary>
        /// Property
        /// </summary>
        [JsonProperty("comments")]
        public CommentReplies Comments { get; set; }

        /// <summary>
        /// Comment ID
        /// </summary>
        [JsonProperty("id")]
        public int? Id { get; set; }

        /// <summary>
        /// Property
        /// </summary>
        [JsonProperty("post_source")]
        public PostSource PostSource { get; set; }

        /// <summary>
        /// Property
        /// </summary>
        [JsonProperty("user")]
        public UserFull User { get; set; }

        /// <summary>
        /// Post type
        /// </summary>
        [JsonProperty("post_type")]
        public int? PostType { get; set; }

        /// <summary>
        /// Property
        /// </summary>
        [JsonProperty("media")]
        public CommentMedia Media { get; set; }

        /// <summary>
        /// Property
        /// </summary>
        [JsonProperty("attachments")]
        public IEnumerable<CommentAttachment> Attachments { get; set; }

        /// <summary>
        /// Wall owner
        /// </summary>
        [JsonProperty("to_id")]
        public int? ToId { get; set; }

        /// <summary>
        /// Information whether current user can delete the comment
        /// </summary>
        [JsonProperty("can_delete")]
        public int? CanDelete { get; set; }

    }
}
