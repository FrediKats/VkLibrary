using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace VkApi.Wrapper.Objects
{
    public class WidgetsWidgetComment
    {
        [JsonProperty("attachments")]
        public WallCommentAttachment[] Attachments { get; set; }

        ///<summary>
        /// Information whether current user can delete the comment
        ///</summary>
        [JsonProperty("can_delete")]
        public int CanDelete { get; set; }
        [JsonProperty("comments")]
        public WidgetsCommentReplies Comments { get; set; }

        ///<summary>
        /// Date when the comment has been added in Unixtime
        ///</summary>
        [JsonProperty("date")]
        public int Date { get; set; }

        ///<summary>
        /// Comment author ID
        ///</summary>
        [JsonProperty("from_id")]
        public int FromId { get; set; }

        ///<summary>
        /// Comment ID
        ///</summary>
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("likes")]
        public BaseLikesInfo Likes { get; set; }
        [JsonProperty("media")]
        public WidgetsCommentMedia Media { get; set; }
        [JsonProperty("post_source")]
        public WallPostSource PostSource { get; set; }

        ///<summary>
        /// Post type
        ///</summary>
        [JsonProperty("post_type")]
        public int PostType { get; set; }
        [JsonProperty("reposts")]
        public BaseRepostsInfo Reposts { get; set; }

        ///<summary>
        /// Comment text
        ///</summary>
        [JsonProperty("text")]
        public String Text { get; set; }

        ///<summary>
        /// Wall owner
        ///</summary>
        [JsonProperty("to_id")]
        public int ToId { get; set; }
        [JsonProperty("user")]
        public UsersUserFull User { get; set; }
    }
}