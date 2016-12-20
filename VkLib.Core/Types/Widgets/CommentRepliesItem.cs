using System;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace VkLib.Types.Widgets 
{
    public class CommentRepliesItem
    {
        /// <summary>
        /// Property
        /// </summary>
        [JsonProperty("likes")]
        public VkLib.Types.Widgets.WidgetLikes Likes { get; set; }

        /// <summary>
        /// Property
        /// </summary>
        [JsonProperty("user")]
        public VkLib.Types.Users.UserFull User { get; set; }

        /// <summary>
        /// User ID
        /// </summary>
        [JsonProperty("uid")]
        public int? Uid { get; set; }

        /// <summary>
        /// Date when the comment has been added in Unixtime
        /// </summary>
        [JsonProperty("date")]
        public int? Date { get; set; }

        /// <summary>
        /// Comment ID
        /// </summary>
        [JsonProperty("cid")]
        public int? Cid { get; set; }

        /// <summary>
        /// Comment text
        /// </summary>
        [JsonProperty("text")]
        public string Text { get; set; }

    }
}
