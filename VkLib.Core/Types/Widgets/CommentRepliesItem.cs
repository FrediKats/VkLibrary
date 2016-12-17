using System;
using Newtonsoft.Json;

namespace VkLib.Types.Widgets 
{
    public class CommentRepliesItem
    {
        /// <summary>
        /// Property
        /// </summary>
        [JsonProperty("user")]
        public UserFull User { get; set; }

        /// <summary>
        /// Date when the comment has been added in Unixtime
        /// </summary>
        [JsonProperty("date")]
        public int? Date { get; set; }

        /// <summary>
        /// User ID
        /// </summary>
        [JsonProperty("uid")]
        public int? Uid { get; set; }

        /// <summary>
        /// Comment text
        /// </summary>
        [JsonProperty("text")]
        public string Text { get; set; }

        /// <summary>
        /// Comment ID
        /// </summary>
        [JsonProperty("cid")]
        public int? Cid { get; set; }

        /// <summary>
        /// Property
        /// </summary>
        [JsonProperty("likes")]
        public WidgetLikes Likes { get; set; }

    }
}
