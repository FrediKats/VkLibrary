using System;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace VkLib.Types.Widgets 
{
    public class WidgetComment
    {
        /// <summary>
        /// Property
        /// </summary>
        [JsonProperty("media")]
        public VkLib.Types.Widgets.CommentMedia Media { get; set; }

        /// <summary>
        /// Comment text
        /// </summary>
        [JsonProperty("text")]
        public string Text { get; set; }

        /// <summary>
        /// Property
        /// </summary>
        [JsonProperty("attachments")]
        public IEnumerable<VkLib.Types.Wall.CommentAttachment> Attachments { get; set; }

        /// <summary>
        /// Property
        /// </summary>
        [JsonProperty("comments")]
        public VkLib.Types.Widgets.CommentReplies Comments { get; set; }

        /// <summary>
        /// Property
        /// </summary>
        [JsonProperty("post_source")]
        public VkLib.Types.Wall.PostSource PostSource_ { get; set; }

        /// <summary>
        /// Information whether current user can delete the comment
        /// </summary>
        [JsonProperty("can_delete")]
        public int? CanDelete_ { get; set; }

        /// <summary>
        /// Property
        /// </summary>
        [JsonProperty("likes")]
        public VkLib.Types.Base.LikesInfo Likes { get; set; }

        /// <summary>
        /// Post type
        /// </summary>
        [JsonProperty("post_type")]
        public int? PostType_ { get; set; }

        /// <summary>
        /// Property
        /// </summary>
        [JsonProperty("reposts")]
        public VkLib.Types.Base.RepostsInfo Reposts { get; set; }

        /// <summary>
        /// Wall owner
        /// </summary>
        [JsonProperty("to_id")]
        public int? ToId_ { get; set; }

        /// <summary>
        /// Comment ID
        /// </summary>
        [JsonProperty("id")]
        public int? Id { get; set; }

        /// <summary>
        /// Comment author ID
        /// </summary>
        [JsonProperty("from_id")]
        public int? FromId_ { get; set; }

        /// <summary>
        /// Date when the comment has been added in Unixtime
        /// </summary>
        [JsonProperty("date")]
        public int? Date { get; set; }

        /// <summary>
        /// Property
        /// </summary>
        [JsonProperty("user")]
        public VkLib.Types.Users.UserFull User { get; set; }

    }
}
